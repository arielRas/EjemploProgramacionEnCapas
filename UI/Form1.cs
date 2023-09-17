using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PedidoBusiness pedidoBusiness = null;

        ProductoBusiness productoBusiness = new ProductoBusiness();        

        List<Producto> productos = new List<Producto>();


        private void Form1_Load(object sender, EventArgs e) //CARGA DE FORMULARIO
        {
            CargarListaProductos();
        }

        private void CargarListaProductos() //CARGA/ACTUALIZA LISTA DE PRODUCTOS Y LOS CARGA EN COMBOBOX
        {
            productos.Clear();

            productos = productoBusiness.GetAllProducto();

            txtBoxProducto.DataSource = productos.ToList();

            txtBoxProducto.DisplayMember = "Descripcion";

            txtBoxProducto.ValueMember = "Id";

            txtBoxProducto.SelectedIndex = -1;

            txtBoxProducto2.DataSource = productos.ToList();

            txtBoxProducto2.DisplayMember = "Descripcion";

            txtBoxProducto2.ValueMember = "Id";

            txtBoxProducto2.SelectedIndex = -1;
        }

        private void ActualizarVistaPedidoActual() //VISTA DE USUARIO DEL PEDIDO ACTUAL
        {
            var pedidoActual = (from detalle in pedidoBusiness.MiPedido
                                join producto in productos on
                                detalle.IdProducto equals producto.Id
                                select new
                                {
                                    pedido = detalle.IdPedido,
                                    producto = producto.Descripcion,
                                    cantidad = detalle.Cantidad,
                                    subtotal = detalle.Subtotal
                                }).ToList();

            dataGridPedido.DataSource = null;
            
            dataGridPedido.DataSource = pedidoActual;
        }

        private void btnSalir_Click(object sender, EventArgs e) //BOTON SALIR
        {
            Application.Exit();
        }


        //---------------------------------SECCION PEDIDO---------------------------------//

        private void btnGenerarPedido_Click(object sender, EventArgs e) //BOTON GENERAR PEDIDO
        {
            try
            {
                var nuevoPedido = new Pedido { Dni = Convert.ToInt64(txtDni.Text) };

                pedidoBusiness = new PedidoBusiness();                

                pedidoBusiness.AltaPedido(nuevoPedido);

                txtDni.Text = string.Empty;

                groupCargarPedido.Enabled = true;

                groupGenerarPedido.Enabled = false;                

                groupCargaProducto.Enabled = false;

                groupModificarProducto.Enabled = false;

                txtBoxCantidad.SelectedIndex = 0;
                
            }
            catch(FormatException)
            {   
                txtDni.Focus();

                MessageBox.Show("El campo DNI solo acepta valores numericos", "AVISO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO");
            }
        }

        private void txtBoxProducto_SelectionChangeCommitted(object sender, EventArgs e) //EVENTO SELECCION ITEM COMBOBOX PRODUCTOS EN PEDIDO
        {
            int idProducto = Convert.ToInt32(txtBoxProducto.SelectedValue);

            txtPrecio.Text = productos.Where(producto => producto.Id == idProducto).Select(producto => producto.Precio).FirstOrDefault().ToString();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e) //BOTON AGREGAR 
        {
            try
            {
                if(txtBoxProducto.SelectedValue != null)
                {
                    Producto productoParaAgregar = productos.FirstOrDefault(producto => producto.Id == Convert.ToInt32(txtBoxProducto.SelectedValue));

                    int cantidad = Convert.ToInt32(txtBoxCantidad.SelectedItem);

                    pedidoBusiness.AgregarAlPedido(new DetallePedido(pedidoBusiness.IdPedido, productoParaAgregar.Id, cantidad, productoParaAgregar.Precio * cantidad));

                    ActualizarVistaPedidoActual();

                    txtBoxProducto.SelectedIndex = -1;

                    txtBoxCantidad.SelectedIndex = -1;

                    txtPrecio.Text = string.Empty;

                    txtBoxCantidad.SelectedIndex = 0;
                }
                else
                    MessageBox.Show("Debe seleccionar un producto", "AVISO");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO");
            }
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e) //BOTON QUITAR
        {
            try
            {
                pedidoBusiness.QuitarDelPedido();

                ActualizarVistaPedidoActual();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO");
            }
        }

        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                pedidoBusiness.ConfirmarPedido();

                txtBoxProducto = null;

                txtBoxCantidad.SelectedIndex = -1;

                txtPrecio.Text = string.Empty;

                dataGridPedido.DataSource = null;

                groupGenerarPedido.Enabled = true;                

                groupCargaProducto.Enabled = true;

                groupModificarProducto.Enabled = true;

                groupCargarPedido.Enabled = false;

                MessageBox.Show("El pedido ha sido cargado con exito", "AVISO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO");
            }            
        }





        //--------------------------SECCION ALTA/MODIF PRODUCTO--------------------------//

        private void btnAltaProducto_Click(object sender, EventArgs e) //BOTON ALTA PRODUCTO
        {
            try
            {
                var nuevoProducto = new Producto { Descripcion = txtNuevaDescripcion.Text, Precio = Convert.ToDouble(txtNuevoPrecio.Text) };

                productoBusiness.AltaProducto(nuevoProducto);

                txtNuevaDescripcion.Text = string.Empty;

                txtNuevoPrecio.Text = string.Empty;

                CargarListaProductos();

                MessageBox.Show($"El producto {nuevoProducto.Descripcion} se agregó con exito", "AVISO");

            }
            catch (FormatException) 
            {
                MessageBox.Show("El campo precio solo admite valores numericos", "AVISO");
            }

            catch(SqlException ex)
            {
                if(ex.Number == 2627)
                {
                    MessageBox.Show("La descripcion que intenta agregar ya existe en la lista de productos", "AVISO");
                }
                else
                    throw ex;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO");
            }            
        }

        private void txtBoxProducto2_SelectionChangeCommitted(object sender, EventArgs e)//EVENTO SELECCION ITEM COMBOBOX PRODUCTOS EN MODIFICAR PRECIO
        {
            int idProducto = Convert.ToInt32(txtBoxProducto2.SelectedValue);

            txtPrecioActual.Text = productos.Where(producto => producto.Id == idProducto).Select(producto => producto.Precio).FirstOrDefault().ToString();
        }

        private void btnModificarPrecioProducto_Click(object sender, EventArgs e) //BOTON MODIFICAR PRECIO
        {
            try
            {
                if (txtBoxProducto2.SelectedValue == null) throw new Exception("Debe seleccionar un producto");

                if (Convert.ToDouble(txtPrecioActual.Text) == Convert.ToDouble(txtModificarPrecio.Text)) throw new Exception("El precio nuevo debe ser diferente al precio actual");

                productoBusiness.ModificarPrecio(Convert.ToInt32(txtBoxProducto2.SelectedValue), Convert.ToDouble(txtModificarPrecio.Text));

                CargarListaProductos();

                txtPrecioActual.Text = string.Empty;

                txtModificarPrecio.Text = string.Empty;

                MessageBox.Show("El precio ha sido modificado con exito", "AVISO");
            }

            catch (FormatException)
            {
                MessageBox.Show("El campo precio solo admite caracteres numericos", "AVISO");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO");
            }
        }





        //--------------------------VISULIZACION DE PEDIDOS--------------------------//
        private void btnMostrarPedidos_Click(object sender, EventArgs e)//BOTON MOSTRAR PEDIDOS
        {
            try
            {
                Form PedidosRealizados = new PedidosRealizados();

                PedidosRealizados.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
