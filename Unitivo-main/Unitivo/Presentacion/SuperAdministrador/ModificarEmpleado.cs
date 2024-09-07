using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class ModificarEmpleado : Form
    {
        public int fila;
        EmpleadoRepositorio empleadoRepositorio = new EmpleadoRepositorio();
        private int idEmpleado = -1;

        //Valores del empleado
        private string? nombreOriginal;
        private string? apellidoOriginal;
        private int? dniOriginal;
        private string? telefonoOriginal;
        private string? direccionOriginal;
        private string? correoOriginal;

        private DateTime? EdadOriginal;


        public ModificarEmpleado(int id)
        {
            InitializeComponent();
            idEmpleado = id;
            MostrarEmpleado(empleadoRepositorio.buscarEmpleado(id));
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarEmailKeyPress((TextBox)sender, e);
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DPFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = DateTimePickerFechaNacimiento.Value;
            DateTime currentDate = DateTime.Now;
            DateTime minDate = currentDate.AddYears(-100);  // Restar 100 años a la fecha actual.

            if (selectedDate > currentDate)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DateTimePickerFechaNacimiento.Value = currentDate;  // Restaurar a la fecha actual.
            }
            else if (selectedDate < minDate)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser hace más de 100 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DateTimePickerFechaNacimiento.Value = minDate;  // Restaurar a 100 años antes de la fecha actual.
            }
        }

        private void MostrarEmpleado(Empleado empleado)
        {
            // Cargar los datos del empleado en los TextBox
            TBNombreEmpleado.Text = empleado.Nombre;
            nombreOriginal = empleado.Nombre;

            TBApellidoEmpleado.Text = empleado.Apellido;
            apellidoOriginal = empleado.Apellido;

            TBDniEmpleado.Text = empleado.Dni.ToString();
            dniOriginal = empleado.Dni;

            TBTelEmpleado.Text = empleado.Telefono;
            telefonoOriginal = empleado.Telefono;

            TBDireccionEmpleado.Text = empleado.Direccion;
            direccionOriginal = empleado.Direccion!;

            TBCorreoEmpleado.Text = empleado.Correo;
            correoOriginal = empleado.Correo;

            DateTimePickerFechaNacimiento.Value = empleado.Edad;
            EdadOriginal = empleado.Edad;
        }

        private void BModEmpleado_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.ValidarCamposNoVacios(this))
            {
                // Obtén los nuevos valores de los TextBox
                string nuevoNombre = TBNombreEmpleado.Text;
                string nuevoApellido = TBApellidoEmpleado.Text;
                int nuevoDni = int.Parse(TBDniEmpleado.Text);
                string nuevoTelefono = TBTelEmpleado.Text;
                string nuevaDireccion = TBDireccionEmpleado.Text;
                string nuevoCorreo = TBCorreoEmpleado.Text;
                DateTime nuevaEdad = DateTimePickerFechaNacimiento.Value;

                // Compara los nuevos valores con los originales
                if (nuevoNombre != nombreOriginal || nuevoApellido != apellidoOriginal || nuevoDni != dniOriginal ||
                    nuevoTelefono != telefonoOriginal || nuevaDireccion != direccionOriginal || nuevoCorreo != correoOriginal || nuevaEdad != EdadOriginal)
                {
                    Empleado empleado = new Empleado();
                    empleado.Id = idEmpleado;
                    empleado.Nombre = nuevoNombre;
                    empleado.Apellido = nuevoApellido;
                    empleado.Dni = nuevoDni;
                    empleado.Telefono = nuevoTelefono;
                    empleado.Direccion = nuevaDireccion;
                    empleado.Correo = nuevoCorreo;
                    empleado.Edad = nuevaEdad;

                    if (empleadoRepositorio.ModificarEmpleado(empleado))
                    {
                        MessageBox.Show("Empleado modificado con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el empleado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("No se han realizado cambios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ningun campo debe estar vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
