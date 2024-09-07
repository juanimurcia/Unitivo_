//using fluentvalidation
using System;
using System.Text;
using FluentValidation;
using Unitivo.Modelos;
using Unitivo.Repositorios.Implementaciones;



namespace Unitivo.Validators
{
    public class ClienteValidators : AbstractValidator<Cliente>
    {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        public ClienteValidators()
        {
            RuleFor(x => x)
                .Must(x => ExisteDniCliente(x.Dni, x.Id)).WithMessage("El Dni ya esta registrado")
                .Must(x => ExisteEmailCliente(x.Correo, x.Id)).WithMessage("El Email ya esta registrado")
                ;
            //validar dni 
            RuleFor(x => x.Dni)
                .NotEmpty().WithMessage("El campo Dni es obligatorio")
                .InclusiveBetween(9999999, 99999999).WithMessage("El campo Dni debe tener 8 caracteres")

                ;
            //validar nombre
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El campo Nombre es obligatorio")
                .Length(3, 50).WithMessage("El campo Nombre debe tener entre 3 y 50 caracteres")
                ;
            //validar apellido
            RuleFor(x => x.Apellido)
                .NotEmpty().WithMessage("El campo Apellido es obligatorio")
                .Length(3, 50).WithMessage("El campo Apellido debe tener entre 3 y 50 caracteres")
                ;
            //validar email
            RuleFor(x => x.Correo)
                .NotEmpty().WithMessage("El campo Email es obligatorio")
                .EmailAddress().WithMessage("El campo Email no es valido")
                .Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").WithMessage("El correo tiene que ser valido")
                
                ;
            //validar telefono
            RuleFor(x => x.Telefono)
                .NotEmpty().WithMessage("El campo Telefono es obligatorio")
                .Length(10, 10).WithMessage("El campo Telefono debe tener 10 caracteres")
                ;
            //validar direccion
            RuleFor(x => x.Direccion)
                .NotEmpty().WithMessage("El campo Direccion es obligatorio")
                .Length(3, 50).WithMessage("El campo Direccion debe tener entre 3 y 50 caracteres")
                ;
        }


        private bool ExisteDniCliente(int dni, int id)
        {
            var cliente = clienteRepositorio.BuscarClientePorDni(dni);
            if (cliente == null)
            {
                return true;
            }
            else
            {
                if (cliente.Id != id)
                {
                    return false;
                }
                return true;
            }
        }

        private bool ExisteEmailCliente(string email, int id)
        {
            var cliente = clienteRepositorio.BuscarClientePorMail(email);
            if (cliente == null)
            {
                return true;
            }
            else
            {
                if (cliente.Id != id)
                {
                    return false;
                }
                return true;
            }
        }

    }
}
