using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business
{
    public class PedidoBusiness
    {
        private int idPedido;

        private PedidoDao pedidoDao = new PedidoDao();

        private List<DetallePedido> miPedido = new List<DetallePedido>();


        
        public List<DetallePedido> MiPedido { get => miPedido; }
        public int IdPedido { get => idPedido; }



        public void AltaPedido(Pedido nuevoPedido)
        {
            if (nuevoPedido.Dni.ToString().Length > 8) throw new Exception("El numero de Dni tiene que tener 8 numeros");

            this.idPedido = pedidoDao.AltaPedido(nuevoPedido.Dni);
        }


        public void AgregarAlPedido(DetallePedido nuevoProducto)
        {
            if (MiPedido.Exists(producto => producto.IdProducto == nuevoProducto.IdProducto)) throw new Exception("Ud ya ha agregado este producto");

            if (nuevoProducto.Cantidad == 0 || nuevoProducto.Cantidad >10) throw new Exception("El rango de cantidad que puede seleccionar es de 1 a 10 productos");

            MiPedido.Add(nuevoProducto);
        }


        public void QuitarDelPedido()
        {
            if (MiPedido.Count == 0) throw new Exception("No se puede quitar el producto porque el pedido se encuentra vacio");

            int index = MiPedido.Count;

            MiPedido.RemoveAt(index - 1);
        }


        public void ConfirmarPedido()
        {
            if (MiPedido.Count == 0) throw new Exception("No se puede confirmar el pedido vacio, por favor agregue al menos un producto");

            MiPedido.ForEach(detallePedido => pedidoDao.ConfirmarPedido(detallePedido));
        }

        public List<Object> GetAllPedidos()
        {
            return pedidoDao.GetAllPedidos();
        }
    }
}
