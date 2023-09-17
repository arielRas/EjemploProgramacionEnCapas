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
    public class ProductoBusiness
    {
        private ProductoDao productoDao = new ProductoDao();

        public void AltaProducto(Producto nuevoProducto)
        {
            if(nuevoProducto.Descripcion == string.Empty || Regex.IsMatch(nuevoProducto.Descripcion, @"^\s+$")) throw new Exception("La descripcion del producto no puede estar en blanco");

            if (nuevoProducto.Precio <= 0) throw new Exception("El valor del producto no puede ser menor o igual a cero");

            productoDao.AltaProducto(nuevoProducto);
        }

        public void ModificarPrecio(int id, double precio)
        {
            if (precio <= 0) throw new Exception("El precio no puede ser menor o igual a cero");

            productoDao.ModificarPrecio(id, precio);
        }

        public List<Producto> GetAllProducto()
        {
            return productoDao.GetAllProducto();
        }
    }
}
