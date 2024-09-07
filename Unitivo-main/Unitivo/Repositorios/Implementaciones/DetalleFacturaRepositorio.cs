using Microsoft.EntityFrameworkCore;
using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorios.Interfaces;

namespace Unitivo.Repositorios.Implementaciones
{
    public class DetalleFacturaRepositorio : DetalleFacturaInterface
    {
        private readonly UnitivoContext? _contexto;

        public DetalleFacturaRepositorio()
        {
            _contexto = Contexto.dbContexto;
            _contexto.Productos.Load();
            _contexto.Talles.Load();
        }

        public bool AgregarDetalleFactura(DetalleFactura detalleFactura)
        {
            try
            {
                detalleFactura.FechaCreacion = DateTime.Now;
                _contexto?.DetalleFacturas.Add(detalleFactura);
                _contexto?.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)
            {
                // Manejar la excepción principal
                MessageBox.Show("An error occurred while saving entity : " + ex.Message);

                // Verificar si hay una excepción interna
                if (ex.InnerException != null)
                {
                    // Manejar la excepción interna
                    MessageBox.Show("Inner exception details: " + ex.InnerException.Message);
                }
                else
                {
                    MessageBox.Show("No inner exception found.");
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Detalle Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

        public List<DetalleFactura> ListarDetalleFacturas(int idFactura)
        {
            List<DetalleFactura> detalleFacturas = (from d in _contexto?.DetalleFacturas
                                                    where d.IdFactura == idFactura
                                                    select d).ToList();
            return detalleFacturas;
        }


        public DetalleFactura BuscarDetalleFactura(int id)
        {
            throw new NotImplementedException();
        }

        public DetalleFactura BuscarDetalleFacturasPorDni(int id)
        {
            throw new NotImplementedException();
        }

        public bool EliminarDetalleFactura(int id)
        {
            throw new NotImplementedException();
        }

        public List<DetalleFactura> ListarDetalleFacturas()
        {
            throw new NotImplementedException();
        }

        public List<DetalleFactura> ListarDetalleFacturasActivos()
        {
            throw new NotImplementedException();
        }

        public bool ModificarDetalleFactura(DetalleFactura DetalleFactura)
        {
            throw new NotImplementedException();
        }
    }
}
