using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorio.Interfaces;
using Unitivo.Sessions;
using Unitivo.Presentacion.Logica.Constructores;
using Unitivo.Validators;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Unitivo.Repositorios.Implementaciones
{
    public class ClienteRepositorio : ClienteInterface{
        private readonly UnitivoContext? _contexto;

        public ClienteRepositorio()
        {
            _contexto = Contexto.dbContexto;
        }

        public bool AgregarCliente(Cliente x)
        {
            try
            {
                var validator = new ClienteValidators();
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

                if (BuscarClientePorDni(x.Dni) != null)
                {
                    MessageBox.Show("El DNI ya está asociado a un cliente.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; // Retorna false si ya existe un cliente con el mismo DNI
                }
                // Validar que el correo sea único

                if (BuscarClientePorMail(x.Correo) != null)
                {
                    MessageBox.Show("El correo ya está asociado a un cliente.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; // Retorna false si ya existe un cliente con el mismo correo
                }
                
                x.FechaCreacion = DateTime.Now;
                x.Estado = true;
                x.UsuarioCreacion = Session.idUsuario;
                // Agrega el cliente al contexto de Entity Framework

                _contexto?.Clientes.Add(x);
                _contexto?.SaveChanges();

                // Retorna true si el cliente se agregó con éxito
                return true;
            }
            catch (Exception ex)
            {
                // Retorna false si hubo un error durante la inserción
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ModificarCliente(Cliente x){
            try
            {
                var validator = new ClienteValidators();
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

                // Agrega el cliente al contexto de Entity Framework

                x.FechaModificacion = DateTime.Now;

                Cliente clienteContexto = (from u in _contexto?.Clientes
                                           where u.Id == x.Id
                                           select u).First();

                clienteContexto.Nombre = x.Nombre;
                clienteContexto.Apellido = x.Apellido;
                clienteContexto.Dni = x.Dni;
                clienteContexto.Telefono = x.Telefono;
                clienteContexto.Direccion = x.Direccion;
                clienteContexto.Correo = x.Correo;
                clienteContexto.FechaModificacion = DateTime.Now;

                _contexto?.SaveChanges();

                // Retorna true si el cliente se agregó con éxito
                return true;
            }
            catch (Exception ex)
            {
                // Retorna false si hubo un error durante la inserción
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool reactivarCliente(int id)
        {
            Cliente cli = (from c in _contexto?.Clientes
                             where c.Id == id
                             select c).First();
            cli.Estado = true;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        } 


        public bool EliminarCliente(int id){
            Cliente? cliente = _contexto?.Clientes.Find(id);
            if(cliente == null) return false;
            cliente.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }


        public Cliente BuscarClientPorId(int id)
        {
            return _contexto?.Clientes.Find(id)!;
        }

        public Cliente BuscarClientePorDni(int dni)
        {
            return _contexto?.Clientes.Where(c => c.Dni == dni).FirstOrDefault()!; 
        }
        
        public List<Cliente> ListarClientes(){
            return _contexto?.Clientes.ToList()!;
        }


        public List<Cliente> ListarClientesActivos()
        {
            return _contexto?.Clientes.Where(c => c.Estado == true).ToList()!;
        }


        public List<Cliente> BuscarCliente(object parametro)
        {
            if (int.TryParse(parametro.ToString(), out int resultado))
            {
                List<Cliente> clientes = _contexto?.Clientes.Where(c => c.Dni == resultado).ToList()!; 
                return clientes;
            }
            else if (parametro is string)
            {
                string cadena = (string)parametro;
                return _contexto?.Clientes
                    .Where(c => c.Nombre.Contains(cadena) || c.Apellido.Contains(cadena))
                    .ToList()!;
            }
            else
            {
                return new List<Cliente>(); 
            }
        }

        public List<Cliente> BuscarClienteActivos(object parametro)
        {
            if (int.TryParse(parametro.ToString(), out int resultado))
            {
                List<Cliente> clientes = _contexto?.Clientes.Where(c => c.Dni == resultado && c.Estado == true).ToList()!;
                return clientes;
            }
            else if (parametro is string)
            {
                string cadena = (string)parametro;
                return _contexto?.Clientes
                    .Where(c => c.Estado == true && (c.Nombre.Contains(cadena) || c.Apellido.Contains(cadena)) )
                    .ToList()!;
            }
            else
            {
                return new List<Cliente>();
            }
        }

        public Cliente BuscarClientePorMail(string mail){
            return _contexto?.Clientes.Where(c => c.Correo == mail).FirstOrDefault()!;
        }
    }
}
