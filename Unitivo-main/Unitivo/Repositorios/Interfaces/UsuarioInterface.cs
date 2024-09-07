using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;

namespace Unitivo.Repositorios.Interfaces
{
    public interface UsuarioInterface
    {
        public void CargarEmpleados();
        public bool AgregarUsuario(Usuario usuario);

        public bool EliminarUsuario(int id);

        public bool ModificarUsuario(Usuario usuario);

        public Usuario BuscarUsuarioPorId(int id);

        public List<Usuario> BuscarUsuario(object parametro);

        public List<Usuario> ListarUsuarios();

        public List<Usuario> ListarUsuariosActivos();

        public Usuario LoggUser(string usuario, string password);
    }
}