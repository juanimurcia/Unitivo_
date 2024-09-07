using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;

namespace Unitivo.Repositorios.Interfaces{
    public interface DetalleFacturaInterface
    {
        public bool AgregarDetalleFactura(DetalleFactura DetalleFactura);
        
        public bool EliminarDetalleFactura(int id);

        public bool ModificarDetalleFactura(DetalleFactura DetalleFactura);

        public DetalleFactura BuscarDetalleFactura(int id);

        public DetalleFactura BuscarDetalleFacturasPorDni(int id);

        public List<DetalleFactura> ListarDetalleFacturas();

        public List<DetalleFactura> ListarDetalleFacturasActivos();
    }
}