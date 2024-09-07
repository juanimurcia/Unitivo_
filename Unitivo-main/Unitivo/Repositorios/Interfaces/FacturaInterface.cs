using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;

namespace Unitivo.Repositorios.Interfaces{
    public interface FacturaInterface
    {
        public bool AgregarFactura(Factura Factura);
        
        public bool EliminarFactura(int id);

        public bool ModificarFactura(Factura Factura);

        public Factura buscarFactura(int id);


        public Factura BuscarFacturasPorDni(int id);


        public List<Factura> ListarFacturas();

        public List<Factura> ListarFacturasActivos();
    }
}