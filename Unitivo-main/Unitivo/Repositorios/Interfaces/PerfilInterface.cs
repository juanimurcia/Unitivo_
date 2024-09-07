using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica.Constructores;

namespace Unitivo.Repositorio.Interfaces
{
    public interface PerfilInterface
    {
        public bool AgregarPerfil(Perfile Perfile);
        public bool EliminarPerfil(int id);
        public bool ModificarPerfil(Perfile Perfile);
        public Perfile BuscarPerfilPorId(int id);

        public List<Perfile> BuscarPerfil(string nombre);
        public List<Perfile> ListarPerfiles();
        public List<Perfile> ListarPerfilesActivos();
    }
}