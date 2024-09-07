using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorios.Interfaces;
using Unitivo.Validators;
namespace Unitivo.Repositorios.Implementaciones
{
    public class EmpleadoRepositorio : EmpleadoInterface
    {
        private readonly UnitivoContext? _contexto;

        public EmpleadoRepositorio()
        {
            _contexto = Contexto.dbContexto;
        }

        public bool AgregarEmpleado(Empleado x)
        {
            try
            {
                //se valida el modelo
                var validator = new EmpleadoValidator();
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

                // se valida que no exista un empleado con el mismo dni
                if (BuscarEmpleadosPorDni(x.Dni) != null)
                {
                    MessageBox.Show("El DNI ya esta asociado a un empleado.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; // Retorna false si ya existe un empleado con el mismo DNI
                }
                //   Validar que el correo sea �nico

                if (BuscarEmpleadosPorMail(x.Correo).Count > 0)
                {
                    MessageBox.Show("El correo ya esta asociado a un empleado.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; // Retorna false si ya existe un empleado con el mismo correo
                }

                if (BuscarEmpleadosPorTelefono(x.Telefono) != null)
                {
                    MessageBox.Show("El telefono ya esta asociado a un empleado.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; // Retorna false si ya existe un empleado con el mismo correo
                }

                // se agregan los demas campos obligatorios
                x.FechaCreacion = DateTime.Now;
                x.Estado = true;

                // Agrega el empleado al contexto de Entity Framework

                _contexto?.Empleados.Add(x);
                _contexto?.SaveChanges();

                // Retorna true si el empleado se agreg� con �xito
                return true;
            }
            catch (ValidationException ex)
            {
                // Retorna false si hubo un error durante la inserci�n

                MessageBox.Show(ex.Message, "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ex.InnerException != null)
                {
                    // Manejar la excepción interna
                    MessageBox.Show("Excepción interna: " + ex.InnerException);
                }
                return false;
            }
            catch (DbUpdateException ex)
            {
                // Manejar error de Entity Framework al guardar cambios
                MessageBox.Show("Error al guardar cambios en la base de datos: " + ex.Message, "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ex.InnerException != null)
                {
                    // Manejar la excepción interna
                    MessageBox.Show("Excepción interna: " + ex.InnerException.Message);
                }
                return false;
            }
            catch (Exception ex)
            {
                // Manejar otros errores no previstos
                MessageBox.Show("Error inesperado al agregar empleado: " + ex.Message, "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public bool EliminarEmpleado(int id)
        {
            Empleado? empleado = (from emp in _contexto?.Empleados
                                  where emp.Id == id
                                  select emp).First();

            if (empleado == null) return false;
            empleado.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public bool ModificarEmpleado(Empleado empleado)
        {
            try
            {
                var validator = new EmpleadoValidator();
                var result = validator.Validate(empleado);

                if (!result.IsValid)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var failure in result.Errors)
                    {
                        sb.AppendLine($"{failure.PropertyName}: {failure.ErrorMessage}");
                    }
                    throw new ValidationException(sb.ToString());
                }

                Empleado empleadoContext = (from emp in _contexto?.Empleados
                                            where emp.Id == empleado.Id
                                            select emp).First();

                empleadoContext.Nombre = empleado.Nombre;
                empleadoContext.Apellido = empleado.Apellido;
                empleadoContext.Dni = empleado.Dni;
                empleadoContext.Telefono = empleado.Telefono;
                empleadoContext.Direccion = empleado.Direccion;
                empleadoContext.Correo = empleado.Correo;
                empleadoContext.Edad = empleado.Edad;

                int resultado = _contexto?.SaveChanges() ?? 0;
                return resultado > 0;
            }
            catch (Exception ex)
            {
                // Retorna false si hubo un error durante la inserci�n
                MessageBox.Show(ex.Message, "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Empleado buscarEmpleado(int id)
        {

            Empleado empleado = (from emp in _contexto?.Empleados
                                 where emp.Id == id
                                 select emp).FirstOrDefault();
            return empleado;
        }

        public Empleado BuscarEmpleadosPorDni(int dni)
        {
            Empleado empleado = (from emp in _contexto?.Empleados
                                 where emp.Dni == dni
                                 select emp).FirstOrDefault();
            return empleado;
        }

        public List<Empleado> BuscarEmpleadosPorMail(string correo)
        {
            List<Empleado> empleados = (from emp in _contexto?.Empleados
                                        where emp.Correo == correo
                                        select emp).ToList();
            return empleados;
        }

        public Empleado BuscarEmpleadosPorTelefono(string tel)
        {
            Empleado empleados = (from emp in _contexto?.Empleados
                                        where emp.Telefono == tel
                                        select emp).FirstOrDefault();
            return empleados;
        }

        public List<Empleado> ListarEmpleados()
        {
            return _contexto?.Empleados.ToList()!;
        }

        public List<Empleado> ListarEmpleados(int dni)
        {
            List<Empleado> empleados = (from emp in _contexto?.Empleados
                                        where emp.Dni == dni
                                        select emp).ToList();
            return empleados;
        }

        public List<Empleado> ListarEmpleados(string nom)
        {
            List<Empleado> empleados = (from emp in _contexto?.Empleados
                                        where emp.Nombre.Contains(nom) || emp.Apellido.Contains(nom)
                                        select emp).ToList();
            return empleados;
        }

        public List<Empleado> ListarEmpleadosActivos()
        {
            return _contexto?.Empleados.Where(c => c.Estado == true).ToList()!;
        }

        public bool ReactivaEmpleado(int id)
        {
            Empleado empleado = (from emp in _contexto?.Empleados
                                 where emp.Id == id
                                 select emp).First();
            empleado.Estado = true;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }
    }
}