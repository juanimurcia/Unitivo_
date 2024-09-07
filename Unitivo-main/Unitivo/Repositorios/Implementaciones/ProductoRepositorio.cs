using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorios.Interfaces;
using Unitivo.Sessions;
using Unitivo.Validators;

namespace Unitivo.Repositorios.Implementaciones
{
    public class ProductoRepositorio : ProductoInterface
    {
        private readonly UnitivoContext? _contexto;
        public ProductoRepositorio()
        {
            _contexto = Contexto.dbContexto;
            _contexto?.Categorias.Load();
            _contexto?.Talles.Load();
            _contexto?.Colores.Load();
        }

        private void CargarTalleYCategorias()
        {
            _contexto?.Categorias.Load();
            _contexto?.Talles.Load();

            LocalStorage.categorias = _contexto?.Categorias.ToList();
            LocalStorage.talles = _contexto?.Talles.ToList();
        }
        public bool AgregarProducto(Producto x)
        {
            try
            {
                var validator = new ProductoValidator();
                var result = validator.Validate(x);

                if (!result.IsValid)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var failure in result.Errors)
                    {
                        sb.AppendLine($"{failure.PropertyName}: {failure.ErrorMessage}");
                    }
                    throw new ValidationException(sb.ToString());
                }

                string nombreAleatorio = Path.Combine("C:\\MisImagenes",
                Guid.NewGuid().ToString() + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg"
                );

                x.Estado = true;
                x.FechaCreacion = DateTime.Now;

                _contexto?.Productos.Add(x);
                _contexto?.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Producto BuscarProducto(int id)
        {
            Producto prod = (from p in _contexto?.Productos
                             where p.Id == id
                             select p).First();
            return prod;
        }

        public bool EliminarProducto(int id)
        {
            Producto? producto = _contexto?.Productos.Find(id);
            if (producto == null) return false;
            producto.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public List<Producto> ListarProductos()
        {
            return _contexto?.Productos.ToList()!;
        }

        public bool ModificarProducto(Producto x, int stockAdic)
        {
            
            var validator = new ProductoValidator();
            var result = validator.Validate(x);

            try
            {
                if (!result.IsValid)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var failure in result.Errors)
                    {
                        sb.AppendLine($"{failure.PropertyName}: {failure.ErrorMessage}");
                    }
                    throw new ValidationException(sb.ToString());
                }


                Producto producto = (from p in _contexto?.Productos
                                      where p.Id == x.Id
                                      select p).First();
                producto.Stock = x.Stock;
                producto.Nombre = x.Nombre;
                producto.Precio = x.Precio;
                producto.Descripcion = x.Descripcion;
                producto.IdCategoria = x.IdCategoria;
                producto.IdTalle = x.IdTalle;
                producto.IdColor = x.IdColor;
                producto.FechaModificacion = DateTime.Now;

                _contexto?.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Producto> ListarProductosActivos()
        {
            return _contexto?.Productos.Where(c => c.Estado == true && c.Stock != 0).ToList()!;
        }

        public List<Producto> ListarProductosActivosVentas()
        {
            return _contexto?.Productos.Where(c => c.Estado == true && c.Stock != 0 && c.IdCategoriaNavigation.Estado == true && c.IdTalleNavigation.Estado == true && c.IdColorNavigation.Estado == true).ToList()!;
        }

        public List<Producto> BuscarProductoNombre(string nombre)
        {
            return _contexto?.Productos.Where(c => c.Nombre.Contains(nombre)).ToList()!;
        }

        public List<Producto> BuscarProductoNombreExacto(string nombre)
        {
            return _contexto?.Productos.Where(c => c.Nombre == nombre).ToList()!;
        }

        public List<Producto> BuscarProductos(string nom, string cat, string talle, string col)
        {
            var prods = (from p in _contexto?.Productos
                         where (string.IsNullOrEmpty(cat) || p.IdCategoriaNavigation.Descripcion == cat) &&
                               (string.IsNullOrEmpty(col) || p.IdColorNavigation.Descripcion == col) &&
                               (string.IsNullOrEmpty(nom) || p.Nombre.Contains(nom)) &&
                               (string.IsNullOrEmpty(talle) || p.IdTalleNavigation.Descripcion == talle)
                         select p).ToList();

            return prods;
        }

        //where p.IdCategoriaNavigation.Descripcion.Contains(cat) && p.IdColorNavigation.Descripcion.Contains(col) && p.Nombre.Contains(nom) && p.IdTalleNavigation.Descripcion.Contains(talle)

        public bool ReducirStockProducto(int id, int stockReducir)
        {

            Producto? producto = (from p in _contexto?.Productos
                                  where p.Id == id
                                  select p).First();

            producto.Stock -= stockReducir;
            if (producto.Stock <= 0)
            {
                producto.Estado = false;
            }

            try
            {
                _contexto?.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Producto> BuscarProductosActivos(string nom, string cat, string talle)
        {

            List<Producto> prods = (from p in _contexto?.Productos
                                    where p.Estado == true && p.IdCategoriaNavigation.Descripcion.Contains(cat) && p.Nombre.Contains(nom) && p.IdTalleNavigation.Descripcion.Contains(talle)
                                    select p).ToList();

            return prods;
        }

        public List<Producto> BuscarProductosActivosVentas(string nom, string cat, string talle, string color)
        {

            List<Producto> prods = (from p in _contexto?.Productos
                                    where (p.Estado == true && 
                                    p.Stock != 0 && p.IdCategoriaNavigation.Estado == true && 
                                    p.IdTalleNavigation.Estado == true && p.IdColorNavigation.Estado == true) &&
                                    (string.IsNullOrEmpty(cat) || p.IdCategoriaNavigation.Descripcion == cat) &&
                                    (string.IsNullOrEmpty(color) || p.IdColorNavigation.Descripcion == color) &&
                                    (string.IsNullOrEmpty(nom) || p.Nombre.Contains(nom)) &&
                                    (string.IsNullOrEmpty(talle) || p.IdTalleNavigation.Descripcion == talle)
                                    select p).ToList();

            return prods;
        }

        public bool reactivarProducto(int idProducto)
        {
            Producto prod = (from p in _contexto?.Productos
                             where p.Id == idProducto
                             select p).First();
            prod.Estado = true;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }


        public object ProductosMasVendidos(DateTime fechaInicio, DateTime fechaFin, bool filtrarFecha)
        {
            object query;


            if (filtrarFecha)
            {
                query = (from detalle in _contexto.DetalleFacturas
                         join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                         where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin
                         group detalle by detalle.IdProductoNavigation into Group
                         orderby Group.Sum(d => d.Cantidad) descending
                         select new { Producto = (Group.Key.IdCategoriaNavigation.Descripcion + " " + Group.Key.Nombre), Cantidad = Group.Sum(d => d.Cantidad) }
                         ).Take(5).ToList();
            }
            else
            {
                query = (from detalle in _contexto.DetalleFacturas
                         join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                         group detalle by detalle.IdProductoNavigation into Group
                         orderby Group.Sum(d => d.Cantidad) descending
                         select new { Producto = (Group.Key.IdCategoriaNavigation.Descripcion + " " + Group.Key.Nombre), Cantidad = Group.Sum(d => d.Cantidad) }
                         ).Take(5).ToList();
            }

            return query;
        }

        public object ProductoPorMes(DateTime fechaInicio, DateTime fechaFin, bool filtrarFecha, int idProducto)
        {
            object query;

            if (idProducto > 0)
            {
                if (filtrarFecha)
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin && detalle.IdProductoNavigation.Id == idProducto
                             group detalle by venta.FechaCreacion.Month into Group
                             select new { Mes = Group.Key, Cantidad = Group.Sum(d => d.Cantidad) }).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             where detalle.IdProductoNavigation.Id == idProducto
                             group detalle by venta.FechaCreacion.Month into Group
                             select new { Mes = Group.Key, Cantidad = Group.Sum(d => d.Cantidad) }).ToList();
                }
            }
            else
            {
                if (filtrarFecha)
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin
                             group detalle by venta.FechaCreacion.Month into Group
                             select new { Mes = Group.Key, Cantidad = Group.Sum(d => d.Cantidad) }).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             group detalle by venta.FechaCreacion.Month into Group
                             select new { Mes = Group.Key, Cantidad = Group.Sum(d => d.Cantidad) }).ToList();
                }
            }

            return query;
        }

        public object EmpleadosMasVendioProd(DateTime fechaInicio, DateTime fechaFin, bool filtrarFecha, int idProducto)
        {
            object query;

            if (idProducto > 0)
            {
                if (filtrarFecha)
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             join vendedor in _contexto.Usuarios on venta.IdUsuario equals vendedor.Id
                             where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin && detalle.IdProductoNavigation.Id == idProducto
                             group detalle by vendedor into Group
                             orderby Group.Sum(d => d.Cantidad) descending
                             select new { Vendedor = $"{Group.Key.IdEmpleadoNavigation.Apellido}, {Group.Key.IdEmpleadoNavigation.Nombre}", Cantidad = Group.Sum(d => d.Cantidad) }
                             ).Take(5).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             join vendedor in _contexto.Usuarios on venta.IdUsuario equals vendedor.Id
                             where detalle.IdProductoNavigation.Id == idProducto
                             group detalle by vendedor into Group
                             orderby Group.Sum(d => d.Cantidad) descending
                             select new { Vendedor = $"{Group.Key.IdEmpleadoNavigation.Apellido}, {Group.Key.IdEmpleadoNavigation.Nombre}", Cantidad = Group.Sum(d => d.Cantidad) }
                             ).Take(5).ToList();
                }
            }
            else
            {
                if (filtrarFecha)
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             join vendedor in _contexto.Usuarios on venta.IdUsuario equals vendedor.Id
                             where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin
                             group detalle by vendedor into Group
                             orderby Group.Sum(d => d.Cantidad) descending
                             select new { Vendedor = $"{Group.Key.IdEmpleadoNavigation.Apellido}, {Group.Key.IdEmpleadoNavigation.Nombre}", Cantidad = Group.Sum(d => d.Cantidad) }
                             ).Take(5).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             join vendedor in _contexto.Usuarios on venta.IdUsuario equals vendedor.Id
                             group detalle by vendedor into Group
                             orderby Group.Sum(d => d.Cantidad) descending
                             select new { Vendedor = $"{Group.Key.IdEmpleadoNavigation.Apellido}, {Group.Key.IdEmpleadoNavigation.Nombre}", Cantidad = Group.Sum(d => d.Cantidad) }
                             ).Take(5).ToList();
                }
            }

            return query;
        }

        public object ClientesMasComproProd(DateTime fechaInicio, DateTime fechaFin, bool filtrarFecha, int idProducto)
        {
            object query;

            if (idProducto > 0)
            {
                if (filtrarFecha)
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             join cliente in _contexto.Clientes on venta.IdCliente equals cliente.Id
                             where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin && detalle.IdProductoNavigation.Id == idProducto
                             group detalle by cliente into Group
                             orderby Group.Sum(d => d.Cantidad) descending
                             select new { Cliente = $"{Group.Key.Apellido}, {Group.Key.Nombre}", Cantidad = Group.Sum(d => d.Cantidad) }
                             ).Take(5).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             join cliente in _contexto.Clientes on venta.IdCliente equals cliente.Id
                             where detalle.IdProductoNavigation.Id == idProducto
                             group detalle by cliente into Group
                             orderby Group.Sum(d => d.Cantidad) descending
                             select new { Cliente = $"{Group.Key.Apellido}, {Group.Key.Nombre}", Cantidad = Group.Sum(d => d.Cantidad) }
                             ).Take(5).ToList();
                }
            }
            else
            {
                if (filtrarFecha)
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             join cliente in _contexto.Clientes on venta.IdCliente equals cliente.Id
                             where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin
                             group detalle by cliente into Group
                             orderby Group.Sum(d => d.Cantidad) descending
                             select new { Cliente = $"{Group.Key.Apellido}, {Group.Key.Nombre}", Cantidad = Group.Sum(d => d.Cantidad) }
                             ).Take(5).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             join cliente in _contexto.Clientes on venta.IdCliente equals cliente.Id
                             group detalle by cliente into Group
                             orderby Group.Sum(d => d.Cantidad) descending
                             select new { Cliente = $"{Group.Key.Apellido}, {Group.Key.Nombre}", Cantidad = Group.Sum(d => d.Cantidad) }
                             ).Take(5).ToList();
                }
            }

            return query;
        }

        public object RecaudadoProductoPorFecha(DateTime fechaInicio, DateTime fechaFin, bool filtrarFecha, int idProducto)
        {
            object query;

            if (idProducto > 0)
            {
                if (filtrarFecha)
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin && detalle.IdProductoNavigation.Id == idProducto
                             group new { detalle, venta } by new { Anio = venta.FechaCreacion.Year, Mes = venta.FechaCreacion.Month } into Group
                             select new { Mes = Group.Key.Mes, Cantidad = Group.Sum(d => d.detalle.Precio), Anio = Group.Key.Anio }
                             ).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             where detalle.IdProductoNavigation.Id == idProducto
                             group new { detalle, venta } by new { Anio = venta.FechaCreacion.Year, Mes = venta.FechaCreacion.Month } into Group
                             select new { Mes = Group.Key.Mes, Cantidad = Group.Sum(d => d.detalle.Precio), Anio = Group.Key.Anio }
                             ).ToList();
                }
            }
            else
            {
                if (filtrarFecha)
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin
                             group new { detalle, venta } by new { Anio = venta.FechaCreacion.Year, Mes = venta.FechaCreacion.Month } into Group
                             select new { Mes = Group.Key.Mes, Cantidad = Group.Sum(d => d.detalle.Precio), Anio = Group.Key.Anio }
                             ).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             group new { detalle, venta } by new { Anio = venta.FechaCreacion.Year, Mes = venta.FechaCreacion.Month } into Group
                             select new { Mes = Group.Key.Mes, Cantidad = Group.Sum(d => d.detalle.Precio), Anio = Group.Key.Anio }
                             ).ToList();
                }
            }

            return query;
        }

        public decimal TotalRecaudadoProducto(DateTime fechaInicio, DateTime fechaFin, bool filtrarFecha, int idProducto)
        {
            decimal total = 0;
            try
            {
                if (idProducto > 0)
                {
                    if (filtrarFecha)
                    {
                        total = (from venta in _contexto.Facturas
                                 join detalle in _contexto.DetalleFacturas on venta.Id equals detalle.IdFactura
                                 where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin && detalle.IdProductoNavigation.Id == idProducto
                                 select detalle.Precio).Sum();
                    }
                    else
                    {
                        total = (from venta in _contexto.Facturas
                                 join detalle in _contexto.DetalleFacturas on venta.Id equals detalle.IdFactura
                                 where detalle.IdProductoNavigation.Id == idProducto
                                 select detalle.Precio).Sum();
                    }
                }
                else
                {
                    if (filtrarFecha)
                    {
                        total = (from venta in _contexto.Facturas
                                 join detalle in _contexto.DetalleFacturas on venta.Id equals detalle.IdFactura
                                 where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin
                                 select detalle.Precio).Sum();
                    }
                    else
                    {
                        total = (from venta in _contexto.Facturas
                                 join detalle in _contexto.DetalleFacturas on venta.Id equals detalle.IdFactura
                                 select detalle.Precio).Sum();
                    }
                }
            }
            catch (Exception ex)
            {
                total = 0;
            }
            return total;
        }
    }

}
