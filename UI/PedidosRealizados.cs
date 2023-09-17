using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class PedidosRealizados : Form
    {
        public PedidosRealizados()
        {
            InitializeComponent();
        }

        private void PedidosRealizados_Load(object sender, EventArgs e) //CARGA DE FORMULARIO
        {
            PedidoBusiness pedidoBusiness = new PedidoBusiness();

            dataGridPedidos.DataSource = null;

            dataGridPedidos.DataSource = pedidoBusiness.GetAllPedidos();
        }

        private void btnSalir_Click(object sender, EventArgs e) //BOTON SALIR
        {
            this.Close();
        }
    }
}
