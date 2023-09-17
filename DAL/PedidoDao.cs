using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PedidoDao
    {
        public int AltaPedido(Int64 dni)
        {
            string conectionString = ConfigurationManager.ConnectionStrings["DbProgramacionEnCapas"].ConnectionString;

            SqlConnection conection = new SqlConnection(conectionString);

            string sqlQuery = "INSERT INTO Pedido VALUES (@dni,GETDATE()); SELECT SCOPE_IDENTITY()";

            try
            {
                using (conection)
                {
                    conection.Open();

                    using (SqlCommand Command = new SqlCommand(sqlQuery, conection))
                    {
                        Command.Parameters.AddWithValue("@dni", dni);

                        return Convert.ToInt32(Command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        


        public void ConfirmarPedido(DetallePedido detallePedido)
        {
            string conectionString = ConfigurationManager.ConnectionStrings["DbProgramacionEnCapas"].ConnectionString;

            SqlConnection conection = new SqlConnection(conectionString);

            string sqlQuery = "INSERT INTO Productos_Pedido VALUES (@idPedido, @idProducto, @cantidad, @subtotal)";

            try
            {
                using(conection)
                {
                    conection.Open();

                    using (SqlCommand Command = new SqlCommand(sqlQuery, conection))
                    {
                        Command.Parameters.AddWithValue("@idPedido", detallePedido.IdPedido);

                        Command.Parameters.AddWithValue("@idProducto", detallePedido.IdProducto);

                        Command.Parameters.AddWithValue("@cantidad", detallePedido.Cantidad);

                        Command.Parameters.AddWithValue("@subtotal", detallePedido.Subtotal);

                        Command.ExecuteNonQuery();
                    }
                } 
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }


        public List<Object> GetAllPedidos()
        {
            string conectionString = ConfigurationManager.ConnectionStrings["DbProgramacionEnCapas"].ConnectionString;

            SqlConnection conection = new SqlConnection(conectionString);

            string sqlQuery = "SELECT A.id_pedido, B.dni_cliente, CAST(B.Fecha AS DATE), SUM(Subtotal) FROM Productos_Pedido AS A JOIN Pedido AS B ON A.id_pedido = B.id_pedido GROUP BY A.id_pedido, B.dni_cliente, B.Fecha";

            try
            {
                using (conection)
                {
                    conection.Open();

                    List<Object> allPedidos = new List<Object>();
                    
                    using (SqlCommand command = new SqlCommand(sqlQuery, conection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var pedido = new
                                {
                                    Id = reader.GetInt32(0),
                                    Dni = reader.GetInt64(1),
                                    FechaPedido = reader.GetDateTime(2),
                                    Monto = reader.GetDecimal(3)
                                };

                                allPedidos.Add(pedido);
                            }

                            return allPedidos;
                        }
                    }
                } 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
