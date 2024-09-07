using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorios.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Unitivo.Repositorios.Implementaciones
{
    public class FacturaRepositorio : FacturaInterface
    {
        private readonly UnitivoContext? _contexto;

        public FacturaRepositorio()
        {
            _contexto = Contexto.dbContexto;
            _contexto?.Clientes.Load();
            _contexto?.Usuarios.Load();
            _contexto?.Empleados.Load();
        }

        public bool AgregarFactura(Factura x)
        {
            try
            {
                // se agregan los demas campos obligatorios
                x.FechaCreacion = DateTime.Now;

                // Agrega el Factura al contexto de Entity Framework

                _contexto?.Facturas.Add(x);
                _contexto?.SaveChanges();

                // Retorna true si el Factura se agreg� con �xito
                return true;
            }
            catch (Exception ex)
            {
                // Retorna false si hubo un error durante la inserci�n
                MessageBox.Show(ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public bool EliminarFactura(int id)
        {
            Factura? Factura = _contexto?.Facturas.Find(id);
            if (Factura == null) return false;
            //Factura.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public bool ModificarFactura(Factura Factura)
        {
            _contexto?.Facturas.Update(Factura);
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public Factura buscarFactura(int id)
        {
            return _contexto?.Facturas.Find(id)!;
        }

        public Factura BuscarFacturasPorDni(int id)
        {
            return _contexto?.Facturas.Find(id)!;
        }

        public List<Factura> ListarFacturas()
        {
            return _contexto?.Facturas.ToList()!;
        }

        public int idUltimaVenta()
        {
            List<Factura> listaVenta = (from p in _contexto?.Facturas
                                        orderby p.Id
                                        select p).ToList();
            Factura ultimaFactura = listaVenta.LastOrDefault();

            return ultimaFactura?.Id ?? 0;
        }

        public Factura UltimaVenta()
        {
            List<Factura> listaVenta = (from p in _contexto?.Facturas
                                        orderby p.Id
                                        select p).ToList();

            return listaVenta.LastOrDefault();
        }

        public List<Factura> ListarFacturasActivos()
        {
            throw new NotImplementedException();
        }

        public List<Factura> VentasPorFechas(DateTime desde, DateTime hasta, string nomUsuario = "")
        {
            List<Factura> ventas;

            if (nomUsuario == "")
            {
                ventas = (from f in _contexto?.Facturas
                          where hasta >= f.FechaCreacion && f.FechaCreacion >= desde
                          select f).ToList();
            }
            else
            {
                ventas = (from f in _contexto?.Facturas
                          where hasta >= f.FechaCreacion && f.FechaCreacion >= desde && (f.IdUsuarioNavigation.IdEmpleadoNavigation.Apellido.Contains(nomUsuario) || f.IdUsuarioNavigation.IdEmpleadoNavigation.Nombre.Contains(nomUsuario))
                          select f).ToList();
            }

            return ventas;
        }

        public List<Factura> VentasPorFechasClientes(DateTime desde, DateTime hasta, string nomCliente = "")
        {
            List<Factura> ventas;

            if (nomCliente == "")
            {
                ventas = (from f in _contexto?.Facturas
                          where hasta >= f.FechaCreacion && f.FechaCreacion >= desde
                          select f).ToList();
            }
            else
            {
                ventas = (from f in _contexto?.Facturas
                          where hasta >= f.FechaCreacion && f.FechaCreacion >= desde && (f.IdClienteNavigation.Apellido.Contains(nomCliente) || f.IdClienteNavigation.Nombre.Contains(nomCliente))
                          select f).ToList();
            }

            return ventas;
        }

        public List<Factura> VentasPorVendedor(string nomUsuario = "")
        {
            List<Factura> ventas;

            ventas = (from f in _contexto?.Facturas
                      where f.IdUsuarioNavigation.IdEmpleadoNavigation.Apellido.Contains(nomUsuario) || f.IdUsuarioNavigation.IdEmpleadoNavigation.Nombre.Contains(nomUsuario)
                      select f).ToList();

            return ventas;
        }


    }
}