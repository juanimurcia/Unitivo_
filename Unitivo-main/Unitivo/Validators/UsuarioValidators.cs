using FluentValidation;
using Unitivo.Modelos;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {

        EmpleadoRepositorio empleadoRepositorio = new EmpleadoRepositorio();

        PerfilRepositorio perfilRepositorio = new PerfilRepositorio();

        UsuariosRepositorio usuariosRepositorio = new UsuariosRepositorio();

        public UsuarioValidator()
        {
            //nombre contrase;a perfil confirmarcontrase;a idempleado
            //valida id empleado
            RuleFor(x => x.IdEmpleado)
                .Must(NoExisteIdEmpleado).WithMessage("El empleado ya esta asociado a un usuario");

            //validar nombre
            RuleFor(x => x.NombreUsuario)
                .NotEmpty().WithMessage("El campo Nombre es obligatorio")
                .Length(3, 50).WithMessage("El campo Nombre debe tener entre 3 y 50 caracteres")
                .Must(ExisteNombreUsuario).WithMessage("El nombre de usuario no existe en la base de datos")
                .Must(NombreUsuarioNoVinculado).WithMessage("El correo ya esta vinculado a un usuario")
                .Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").WithMessage("El correo tiene que ser valido")
                ;
            //validar password
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("El campo Password es obligatorio")
                .Length(10, 50).WithMessage("El password debe contener al menos 10 caracteres")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{10,50}$").WithMessage("El password debe tener al menos una mayuscula, y un caracter especial")
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

        private bool ExisteNombreUsuario(string nombreUsuario)
        {
            if (empleadoRepositorio.BuscarEmpleadosPorMail(nombreUsuario).Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool NoExisteIdEmpleado(int idEmpleado)
        {
            if (usuariosRepositorio.BuscarUsuarioIdEmpleado(idEmpleado).Count > 0)
            {
                return false;
            }
            else
            {
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
                return false;
            }
        }
    }
}
