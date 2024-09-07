using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Text;
using Unitivo.Modelos;
using Unitivo.Presentacion;
using Unitivo.Recursos;
using Unitivo.Repositorios.Interfaces;
using Unitivo.Sessions;
using Unitivo.Validators;

namespace Unitivo.Repositorios.Implementaciones
{
    public class UsuariosRepositorio : UsuarioInterface
    {
        private readonly UnitivoContext? _contexto;
        EmpleadoRepositorio empleadoRepositorio = new EmpleadoRepositorio();

        public UsuariosRepositorio()
        {
            _contexto = Contexto.dbContexto;
            CargarEmpleados();
        }

        public void CargarEmpleados()
        {
            _contexto?.Empleados.Load();
            _contexto?.Perfiles.Load();
        }

        public bool AgregarUsuario(Usuario x)
        {
            try
            {
                var validator = new UsuarioValidator();
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

                //debo encriptar la contraseña
                string salt = BCrypt.Net.BCrypt.GenerateSalt();

                x.Password = BCrypt.Net.BCrypt.HashPassword(x.Password, salt);


                x.Estado = true;
                x.FechaCreacion = DateTime.Now;
                x.FechaModificacion = x.FechaCreacion;
                _contexto?.Usuarios.Add(x);
                _contexto?.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (ex.InnerException != null)
                {
                    message += "\nInner Exception: " + ex.InnerException.Message;
                }
                MessageBox.Show(message, "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            return _contexto?.Usuarios.Find(id)!;
        }

        public bool reactivarUsuario(int id)
        {

            Usuario user = (from u in _contexto?.Usuarios
                            where u.Id == id
                            select u).First();
            user.Estado = true;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;

        }

        public List<Usuario> BuscarUsuario(object parametro)
        {
            if (int.TryParse(parametro.ToString(), out int id))
            {
                List<Usuario> usuarios = _contexto?.Usuarios.Where(u => u.Id == id).ToList()!;
                return usuarios;
            }
            else if (parametro is string)
            {
                string cadena = (string)parametro;
                return _contexto?.Usuarios.Where(u => u.NombreUsuario!.Contains(cadena)).ToList()!;
            }
            else
            {
                return new List<Usuario>();
            }
        }

        public List<Usuario> BuscarCorreoUsuario(string correoUsuario)
        {
            List<Usuario> usuariosContexto = (from u in _contexto?.Usuarios
                                              where u.NombreUsuario == correoUsuario
                                              select u).ToList();
            return usuariosContexto;
        }
        public List<Usuario> BuscarUsuarioIdEmpleado(int idEmpleado)
        {
            List<Usuario> usuariosContexto = (from u in _contexto?.Usuarios
                                              where u.IdEmpleado == idEmpleado
                                              select u).ToList();
            return usuariosContexto;
        }


        public bool EliminarUsuario(int id)
        {
            Usuario? usuario = _contexto?.Usuarios.Find(id);
            if (usuario == null) return false;
            usuario.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public List<Usuario> ListarUsuarios()
        {
            CargarEmpleados();
            return _contexto?.Usuarios.ToList()!;
        }

        public List<Usuario> ListarUsuariosActivos()
        {
            CargarEmpleados();
            return _contexto?.Usuarios.Where(u => u.Estado == true).ToList()!;
        }
        public bool ModificarUsuario(Usuario x)
        {
            try
            {
                var validator = new UsuarioModificadorValidator();
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

                Usuario usuarioContexto = (from u in _contexto?.Usuarios
                                           where u.Id == x.Id
                                           select u).First();

                usuarioContexto.NombreUsuario = x.NombreUsuario;
                usuarioContexto.IdPerfil = x.IdPerfil;
                usuarioContexto.FechaModificacion = DateTime.Now;

                if (x.Password != "")
                {
                    var validatorPassword = new PasswordModificadorValidator();
                    var resultPassword = validatorPassword.Validate(x);
                    if (!resultPassword.IsValid)
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (var failure in resultPassword.Errors)
                        {
                            sb.AppendLine($"{failure.PropertyName}: {failure.ErrorMessage}");
                        }
                        throw new ValidationException(sb.ToString());
                    }
                    else
                    {
                        string salt = BCrypt.Net.BCrypt.GenerateSalt();

                        usuarioContexto.Password = x.Password;

                        usuarioContexto.Password = BCrypt.Net.BCrypt.HashPassword(usuarioContexto.Password, salt);
                    }

                }


                int resultado = _contexto?.SaveChanges() ?? 0;
                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Usuario LoggUser(string usuario, string password)
        {
            try
            { 
                Usuario? user = (from u in _contexto!.Usuarios
                                 where u.NombreUsuario == usuario
                                 select u).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Usuario no encontrado", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null!;
                }
                else
                {
                    if (BCrypt.Net.BCrypt.Verify(password, user.Password))
                    {
                        if (user.Estado == false || user.IdEmpleadoNavigation.Estado == false)
                        {
                            MessageBox.Show("Usuario o empleado desactivado", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null!;
                        }
                        else
                        {
                            //Session.usuario = user;
                            return user;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null!;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null!;
            }
        }


        public List<Usuario> listarVendedores()
        {
            return _contexto?.Usuarios.Where(u => u.IdPerfilNavigation.DescripcionPerfil == "Vendedor").ToList()!;
        }

        public List<Usuario> listarVendedoresActivos()
        {
            return _contexto?.Usuarios.Where(u => u.IdPerfilNavigation.DescripcionPerfil == "Vendedor" && u.Estado == true).ToList()!;
        }

        public List<Usuario> buscarVendedores(object parametro)
        {
            if (int.TryParse(parametro.ToString(), out int id))
            {
                List<Usuario> usuarios = _contexto?.Usuarios.Where(u => (u.Id == id) && (u.IdPerfilNavigation.DescripcionPerfil == "Vendedor")).ToList()!;
                return usuarios;
            }
            else if (parametro is string)
            {
                string cadena = (string)parametro;
                return _contexto?.Usuarios.Where(u => (u.NombreUsuario!.Contains(cadena) && (u.IdPerfilNavigation.DescripcionPerfil == "Vendedor"))).ToList()!;
            }
            else
            {
                return new List<Usuario>();
            }
        }
    }
}
