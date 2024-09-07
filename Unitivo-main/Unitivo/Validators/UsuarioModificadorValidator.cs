using FluentValidation;
using Unitivo.Modelos;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Validators
{
    public class UsuarioModificadorValidator : AbstractValidator<Usuario>
    {

        EmpleadoRepositorio empleadoRepositorio = new EmpleadoRepositorio();

        PerfilRepositorio perfilRepositorio = new PerfilRepositorio();

        UsuariosRepositorio usuariosRepositorio = new UsuariosRepositorio();

        public UsuarioModificadorValidator()
        {
            //nombre contrase;a perfil confirmarcontrase;a idempleado
            //validar nombre
            RuleFor(x => x)
                .Must(x => ExisteNombreUsuario(x.NombreUsuario, x.Id)).WithMessage("El nombre de usuario ya existe en la base de datos")
                ;

            RuleFor(x => x.NombreUsuario)
                .NotEmpty().WithMessage("El campo Nombre es obligatorio")
                .Length(3, 50).WithMessage("El campo Nombre debe tener entre 3 y 50 caracteres")
                .Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").WithMessage("El correo tiene que ser valido")
                ;
            //validar IdPerfil
            RuleFor(x => x.IdPerfil)
                .NotEmpty().WithMessage("El campo IDPerfil es obligatorio")
                .Must(x => x > 0).WithMessage("El campo IDPerfil debe ser mayor a 0")
                .Must(ExistePerfil).WithMessage("El perfil no existe en la base de datos")
                ;
            //validar idEmpleado
            RuleFor(x => x.IdEmpleado)
                .NotEmpty().WithMessage("El campo id es obligatorio")
                .Must(ExisteId).WithMessage("El empleado no existe en la base de datos");
            ;
        }

        private bool ExisteNombreUsuario(string nombreUsuario, int id)
        {
            var usuarios = usuariosRepositorio.BuscarCorreoUsuario(nombreUsuario);
            if (usuarios.Count < 1)
            {
                return true;
            }
            else
            {
                foreach (Usuario user in usuarios)
                {
                    if (user.Id != id)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private bool NombreUsuarioNoVinculado(string nombreUsuario)
        {
            if (usuariosRepositorio.BuscarUsuario(nombreUsuario).Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ExistePerfil(int idPerfil)
        {
            if (perfilRepositorio.BuscarPerfilPorId(idPerfil) != null)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
        private bool ExisteId(int id)
        {
            if (empleadoRepositorio.buscarEmpleado(id) != null)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
