using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pedido
    {
        private int id;

        private Int64 dni;

        private DateTime fechaPedido;


        public int Id { get => id; set => id = value; }
        public long Dni { get => dni; set => dni = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
    }
}
