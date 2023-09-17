using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetallePedido
    {
        public DetallePedido(int idPedido, int idProducto, int cantidad, double subtotal)
        {
            this.IdPedido = idPedido;
            this.IdProducto = idProducto;
            this.Cantidad = cantidad;
            this.Subtotal = subtotal;
        }

        private int idPedido;

        private int idProducto;

        private int cantidad;

        private double subtotal;

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
    }
}
