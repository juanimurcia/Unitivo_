using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;

namespace Unitivo.Repositorios.Interfaces
{
    public interface ProductoInterface
    {
        public bool AgregarProducto(Producto producto);
        public bool EliminarProducto(int id);
        public bool ModificarProducto(Producto producto, int stock);
        public Producto BuscarProducto(int id);
        public List<Producto> ListarProductos();
        public List<Producto> ListarProductosActivos();
        public List<Producto> BuscarProductoNombre(string nombre);
    }
}
