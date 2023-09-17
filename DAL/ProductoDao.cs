using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class ProductoDao
    {
        public void AltaProducto(Producto nuevoProducto)
        {
            string conectionString = ConfigurationManager.ConnectionStrings["DbProgramacionEnCapas"].ConnectionString;

            SqlConnection conection = new SqlConnection(conectionString);

            string sqlQuery = "INSERT INTO Producto VALUES (@descripcion, @precio)";

            try
            {
                using(conection)
                {
                    conection.Open();

                    using(SqlCommand Command = new SqlCommand(sqlQuery, conection))
                    {
                        Command.Parameters.AddWithValue("@descripcion", nuevoProducto.Descripcion);
                       
                        Command.Parameters.AddWithValue("@precio", nuevoProducto.Precio);

                        Command.ExecuteNonQuery();
                    }
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void ModificarPrecio(int id, double precio)
        {
            string conectionString = ConfigurationManager.ConnectionStrings["DbProgramacionEnCapas"].ConnectionString;
            SqlConnection conection = new SqlConnection(conectionString);

            try
            {
                string sqlQuery = "UPDATE Producto SET precio = @precio WHERE id_producto = @idProducto";

                SqlCommand Command = new SqlCommand(sqlQuery, conection);

                Command.Parameters.AddWithValue("@idProducto", id);

                Command.Parameters.AddWithValue("@precio", precio);

                conection.Open();

                Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conection.Close();
            }
        }


        public List<Producto> GetAllProducto()
        {
            string conectionString = ConfigurationManager.ConnectionStrings["DbProgramacionEnCapas"].ConnectionString;
            
            SqlConnection conection = new SqlConnection(conectionString);
            
            string sqlQuery = "SELECT * FROM Producto ORDER BY descripcion";
           
            try
            {
                using(conection)
                {
                    conection.Open();

                    DataSet ds = new DataSet();

                    using(SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conection))
                    {
                        adapter.Fill(ds);

                        var allProducts = (from row in ds.Tables[0].AsEnumerable()
                                           select new Producto
                                           {
                                               Id = Convert.ToInt32(row["id_producto"]),
                                               Descripcion = row["descripcion"].ToString(),
                                               Precio = Convert.ToDouble(row["Precio"])
                                           }).ToList();

                        return allProducts;
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
