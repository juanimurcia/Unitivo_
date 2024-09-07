using System.Windows.Forms;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class AñadirEmpleado : Form
    {
        EmpleadoRepositorio empleadoRepositorio = new EmpleadoRepositorio();
        public AñadirEmpleado()
        {
            InitializeComponent();
            CargarEmpleados();
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
            //else if (selectedDate < minDate)
            //{
            //    MessageBox.Show("La fecha de nacimiento no puede ser hace más de 100 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    DateTimePickerFechaNacimiento.Value = minDate;  // Restaurar a 100 años antes de la fecha actual.
            //}
        }

        public bool esVacio(TextBox tb)
        {
            return tb.Text.Trim() != "";
        }

        private void BRegistrarEmpleado_Click(object sender, EventArgs e)
        {

            if (CommonFunctions.ValidarCamposNoVacios(this) )
            {

                Empleado empleado = new Empleado();
                empleado.Nombre = TBNombreEmpleado.Text;
                empleado.Apellido = TBApellidoEmpleado.Text;
                empleado.Dni = int.Parse(TBDniEmpleado.Text);
                empleado.Telefono = TBTelEmpleado.Text;
                empleado.Direccion = TBDireccionEmpleado.Text;
                empleado.Correo = TBCorreoEmpleado.Text;
                empleado.Edad = DateTimePickerFechaNacimiento.Value;


                if (empleadoRepositorio.AgregarEmpleado(empleado))
                {
                    MessageBox.Show("Empleado agregado correctamente");
                    LimpiarTextBoxs();
                    CargarEmpleados();
                }
                else
                {
                    MessageBox.Show("Error al agregar empleado");
                }

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarEmpleados()
        {

            List<Empleado> empleados = empleadoRepositorio.ListarEmpleadosActivos();
            DataGridViewListarEmpleados.Rows.Clear();
            DataGridViewListarEmpleados.Refresh();
            foreach (Empleado empleado in empleados)
            {
                if (empleado.Estado == true)
                {
                    DataGridViewListarEmpleados.Rows.Add(empleado.Id, empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.Telefono, empleado.Direccion, empleado.Correo, empleado.Edad);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListarEmpleados.Rows.Add(empleado.Id, empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.Telefono, empleado.Direccion, empleado.Correo, empleado.Edad, "Inactivo");

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListarEmpleados.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        // Método para limpiar los TextBox después de agregar un empleado.
        private void LimpiarTextBoxs()
        {
            TBNombreEmpleado.Clear();
            TBApellidoEmpleado.Clear();
            TBDniEmpleado.Clear();
            TBTelEmpleado.Clear();
            TBDireccionEmpleado.Clear();
            TBCorreoEmpleado.Clear();
        }

        private void AñadirEmpleado_Load(object sender, EventArgs e)
        {

        }

    }
}
