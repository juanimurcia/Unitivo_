using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;

namespace Unitivo.Repositorios.Interfaces
{
    public interface TalleInterface
    {
        public bool AgregarTalle(Talle Talle);
        public bool EliminarTalle(int id);
        public bool ModificarTalle(Talle Talle);

        public Talle BuscarTallePorId(int id);
        public List<Talle> BuscarTalle(string descripcion);

        public List<Talle> ListarTalles();
        public List<Talle> ListarTallesActivos();
    }
}
