using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorio.Interfaces;
using Unitivo.Sessions;
using Unitivo.Presentacion.Logica.Constructores;
using Unitivo.Validators;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace Unitivo.Repositorios.Implementaciones
{
    public class CategoriaRepositorio : CategoriaInterface{
        private readonly UnitivoContext? _contexto;

        public CategoriaRepositorio()
        { 
            _contexto = Contexto.dbContexto;
            _contexto?.TipoTalles.Load();
        }    
        
        public bool AgregarCategoria(Categoria x){
            if (BuscarCategoriaExacta(x.Descripcion).Count > 0)
            {
                return false;
            }
            try{
                x.Estado = true;
                _contexto?.Categorias.Add(x);
                _contexto?.SaveChanges();
                return true;
            }   
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 
        }
        public bool EliminarCategoria(int id){
            Categoria? Categoria = _contexto?.Categorias.Find(id);
            if(Categoria == null) return false;
            Categoria.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }
        public bool ModificarCategoria(Categoria Categoria){
            try
            {
                if(BuscarCategoriaExacta(Categoria.Descripcion).Count > 0){
                    MessageBox.Show("Ya existe un Categoria con esa descripcion", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _contexto?.Categorias.Update(Categoria);
                int resultado = _contexto?.SaveChanges() ?? 0;
                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public Categoria BuscarCategoriaPorId(int id){
            Categoria Categoria = _contexto?.Categorias.Find(id)!;
            return Categoria;
        
        }
        
        public List<Categoria> BuscarCategoria(string nombre){
            List<Categoria> Categorias = _contexto?.Categorias.Where(x => x.Descripcion.Contains(nombre)).ToList()!;
            return Categorias;
        }

        public List<Categoria> BuscarCategoriaExacta(string nombre)
        {
            List<Categoria> Categorias = _contexto?.Categorias.Where(x => x.Descripcion == nombre).ToList()!;
            return Categorias;
        }

        public List<Categoria> ListarCategorias(){
            List<Categoria> Categorias = _contexto?.Categorias.ToList()!;
            return Categorias;
        }
        public List<Categoria> ListarCategoriasActivos(){
            List<Categoria> Categorias = _contexto?.Categorias.Where(x => x.Estado == true).ToList()!;
            return Categorias;
        }

        public bool reactivarCategoria(int id)
        {
            Categoria cat = (from c in _contexto?.Categorias
                            where c.Id == id
                            select c).First();
            cat.Estado = true;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public object categoriasMasVendidas(DateTime fechaInicio, DateTime fechaFin, bool filtrarFecha)
        {
            object query;

            if (filtrarFecha)
            {
                query = (from detalle in _contexto.DetalleFacturas
                         join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                         where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin
                         group detalle by detalle.IdProductoNavigation.IdCategoriaNavigation into Group
                         orderby Group.Sum(d => d.Cantidad) descending
                         select new { Categoria = Group.Key.Descripcion , Cantidad = Group.Sum(d => d.Cantidad) }
                         ).Take(10).ToList(); 
            }
            else
            {
                query = (from detalle in _contexto.DetalleFacturas
                         join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                         group detalle by detalle.IdProductoNavigation.IdCategoriaNavigation into Group
                         orderby Group.Sum(d => d.Cantidad) descending
                         select new { Categoria = Group.Key.Descripcion, Cantidad = Group.Sum(d => d.Cantidad) }
                         ).Take(10).ToList();
            }

            return query;
        }

        public object categoriaPorMes(DateTime fechaInicio, DateTime fechaFin, bool filtrarFecha, int idCategoria)
        {
            object query;

            if (idCategoria > 0)
            {
                if (filtrarFecha)
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin && detalle.IdProductoNavigation.IdCategoria == idCategoria
                             group new { venta.FechaCreacion.Year, venta.FechaCreacion.Month, detalle.Cantidad } by new { Mes = venta.FechaCreacion.Month, Anio = venta.FechaCreacion.Year } into Group
                             select new { Mes = Group.Key.Mes, Cantidad = Group.Sum(d => d.Cantidad), Anio = Group.Key.Anio }
                             ).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             where detalle.IdProductoNavigation.IdCategoria == idCategoria
                             group new { venta.FechaCreacion.Year, venta.FechaCreacion.Month, detalle.Cantidad } by new { Mes = venta.FechaCreacion.Month, Anio = venta.FechaCreacion.Year } into Group
                             select new { Mes = Group.Key.Mes, Cantidad = Group.Sum(d => d.Cantidad), Anio = Group.Key.Anio }
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
                             group new { venta.FechaCreacion.Year, venta.FechaCreacion.Month, detalle.Cantidad } by new { Mes = venta.FechaCreacion.Month, Anio = venta.FechaCreacion.Year } into Group
                             select new { Mes = Group.Key.Mes, Cantidad = Group.Sum(d => d.Cantidad), Anio = Group.Key.Anio }
                             ).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             group new { venta.FechaCreacion.Year, venta.FechaCreacion.Month, detalle.Cantidad } by new { Mes = venta.FechaCreacion.Month, Anio = venta.FechaCreacion.Year } into Group
                             select new { Mes = Group.Key.Mes, Cantidad = Group.Sum(d => d.Cantidad), Anio = Group.Key.Anio }
                             ).ToList();
                }
            }

            return query;
        }

        public object empleadosMasVendioCateg(DateTime fechaInicio, DateTime fechaFin, bool filtrarFecha, int idCategoria)
        {
            object query;

            if (idCategoria > 0)
            {
                if (filtrarFecha)
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             join vendedor in _contexto.Usuarios on venta.IdUsuario equals vendedor.Id
                             where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin && detalle.IdProductoNavigation.IdCategoria == idCategoria
                             group detalle by vendedor into Group
                             orderby Group.Sum(d => d.Cantidad) descending
                             select new { Vendedor = Group.Key.IdEmpleadoNavigation.Apellido + ", " + Group.Key.IdEmpleadoNavigation.Nombre, Cantidad = Group.Sum(d => d.Cantidad) }
                             ).Take(5).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             join vendedor in _contexto.Usuarios on venta.IdUsuario equals vendedor.Id
                             where detalle.IdProductoNavigation.IdCategoria == idCategoria
                             group detalle by vendedor into Group
                             orderby Group.Sum(d => d.Cantidad) descending
                             select new { Vendedor = Group.Key.IdEmpleadoNavigation.Apellido + ", " + Group.Key.IdEmpleadoNavigation.Nombre, Cantidad = Group.Sum(d => d.Cantidad) }
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
                             select new { Vendedor = Group.Key.IdEmpleadoNavigation.Apellido + ", " + Group.Key.IdEmpleadoNavigation.Nombre, Cantidad = Group.Sum(d => d.Cantidad) }
                             ).Take(5).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             join vendedor in _contexto.Usuarios on venta.IdUsuario equals vendedor.Id
                             group detalle by vendedor into Group
                             orderby Group.Sum(d => d.Cantidad) descending
                             select new { Vendedor = Group.Key.IdEmpleadoNavigation.Apellido + ", " + Group.Key.IdEmpleadoNavigation.Nombre, Cantidad = Group.Sum(d => d.Cantidad) }
                             ).Take(5).ToList();
                }
            }

            return query;
        }

        public object clientesMasComproCateg(DateTime fechaInicio, DateTime fechaFin, bool filtrarFecha, int idCategoria)
        {
            object query;

            if (idCategoria > 0)
            {
                if (filtrarFecha)
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             join cliente in _contexto.Clientes on venta.IdCliente equals cliente.Id
                             where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin && detalle.IdProductoNavigation.IdCategoria == idCategoria
                             group detalle by cliente into Group
                             orderby Group.Sum(d => d.Cantidad) descending
                             select new { Cliente = Group.Key.Apellido + ", " + Group.Key.Nombre, Cantidad = Group.Sum(d => d.Cantidad) }
                             ).Take(5).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             join cliente in _contexto.Clientes on venta.IdCliente equals cliente.Id
                             where detalle.IdProductoNavigation.IdCategoria == idCategoria
                             group detalle by cliente into Group
                             orderby Group.Sum(d => d.Cantidad) descending
                             select new { Cliente = Group.Key.Apellido + ", " + Group.Key.Nombre, Cantidad = Group.Sum(d => d.Cantidad) }
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
                             select new { Cliente = Group.Key.Apellido + ", " + Group.Key.Nombre, Cantidad = Group.Sum(d => d.Cantidad) }
                             ).Take(5).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             join cliente in _contexto.Clientes on venta.IdCliente equals cliente.Id
                             group detalle by cliente into Group
                             orderby Group.Sum(d => d.Cantidad) descending
                             select new { Cliente = Group.Key.Apellido + ", " + Group.Key.Nombre, Cantidad = Group.Sum(d => d.Cantidad) }
                             ).Take(5).ToList();
                }
            }

            return query;
        }

        public object recaudadoCategoriaPorFecha(DateTime fechaInicio, DateTime fechaFin, bool filtrarFecha, int idCategoria)
        {
            object query;

            if (idCategoria > 0)
            {
                if (filtrarFecha)
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin && detalle.IdProductoNavigation.IdCategoria == idCategoria
                             group new { Anio = venta.FechaCreacion.Year, Mes = venta.FechaCreacion.Month, Precio = detalle.Precio } by new { Anio = venta.FechaCreacion.Year, Mes = venta.FechaCreacion.Month } into Group
                             select new { Mes = Group.Key.Mes, Cantidad = Group.Sum(d => d.Precio), Anio = Group.Key.Anio }
                             ).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             where detalle.IdProductoNavigation.IdCategoria == idCategoria
                             group new { Anio = venta.FechaCreacion.Year, Mes = venta.FechaCreacion.Month, Precio = detalle.Precio } by new { Anio = venta.FechaCreacion.Year, Mes = venta.FechaCreacion.Month } into Group
                             select new { Mes = Group.Key.Mes, Cantidad = Group.Sum(d => d.Precio), Anio = Group.Key.Anio }
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
                             group new { Anio = venta.FechaCreacion.Year, Mes = venta.FechaCreacion.Month, Precio = detalle.Precio } by new { Anio = venta.FechaCreacion.Year, Mes = venta.FechaCreacion.Month } into Group
                             select new { Mes = Group.Key.Mes, Cantidad = Group.Sum(d => d.Precio), Anio = Group.Key.Anio }
                             ).ToList();
                }
                else
                {
                    query = (from detalle in _contexto.DetalleFacturas
                             join venta in _contexto.Facturas on detalle.IdFactura equals venta.Id
                             group new { Anio = venta.FechaCreacion.Year, Mes = venta.FechaCreacion.Month, Precio = detalle.Precio } by new { Anio = venta.FechaCreacion.Year, Mes = venta.FechaCreacion.Month } into Group
                             select new { Mes = Group.Key.Mes, Cantidad = Group.Sum(d => d.Precio), Anio = Group.Key.Anio }
                             ).ToList();
                }
            }

            return query;
        }

        public object TotalRecaudadoCategoria(DateTime fechaInicio, DateTime fechaFin, bool filtrarFecha, int idCategoria)
        {
            object query;
            try
            {
                if (idCategoria > 0)
                {
                    if (filtrarFecha)
                    {
                        query = (from venta in _contexto.Facturas
                                 join detalle in _contexto.DetalleFacturas on venta.Id equals detalle.IdFactura
                                 where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin && detalle.IdProductoNavigation.IdCategoria == idCategoria
                                 select detalle.Precio).Sum();
                    }
                    else
                    {
                        query = (from venta in _contexto.Facturas
                                 join detalle in _contexto.DetalleFacturas on venta.Id equals detalle.IdFactura
                                 where detalle.IdProductoNavigation.IdCategoria == idCategoria
                                 select detalle.Precio).Sum();
                    }
                }
                else
                {
                    if (filtrarFecha)
                    {
                        query = (from venta in _contexto.Facturas
                                 join detalle in _contexto.DetalleFacturas on venta.Id equals detalle.IdFactura
                                 where venta.FechaCreacion >= fechaInicio && venta.FechaCreacion <= fechaFin
                                 select detalle.Precio).Sum();
                    }
                    else
                    {
                        query = (from venta in _contexto.Facturas
                                 join detalle in _contexto.DetalleFacturas on venta.Id equals detalle.IdFactura
                                 select detalle.Precio).Sum();
                    }
                }
            }
            catch (Exception ex)
            {
                query = 0;
            }
            return query;
        }

        public List<Categoria> ListarCategoriasPorTipo(int tipoTalleId)
        {
            return _contexto.Categorias.Where(c => c.TipoTalleId == tipoTalleId && c.Estado).ToList();
        }
    }
}