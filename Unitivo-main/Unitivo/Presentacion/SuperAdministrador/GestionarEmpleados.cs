using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class GestionarEmpleados : Form
    {
        EmpleadoRepositorio empleadoRepositorio = new EmpleadoRepositorio();

        public GestionarEmpleados()
        {
            InitializeComponent();
            CargarEmpleados();
            // Establecer la selección inicial en la primera opción.
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ComboBoxBuscarDni.Text == "DNI")
            {
                CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
            }
            else
            {
                CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
            }
        }

        private void BModificarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int idSeleccionado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["ID"].Value);

                ModificarEmpleado modificarEmpleadoForm = new ModificarEmpleado(idSeleccionado);

                DialogResult result = modificarEmpleadoForm.ShowDialog();

                CargarEmpleados();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
        }

        private void CargarEmpleados()
        {
            List<Modelos.Empleado> empleados = empleadoRepositorio.ListarEmpleados();
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Refresh();
            foreach (Modelos.Empleado empleado in empleados)
            {
                if (empleado.Estado == true)
                {
                    dgvEmpleados.Rows.Add(empleado.Id, empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.Telefono, empleado.Direccion, empleado.Correo, empleado.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvEmpleados.Rows.Add(empleado.Id, empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.Telefono, empleado.Direccion, empleado.Correo, empleado.Estado);

                    // Establecer el color de fondo de la fila agregada
                    dgvEmpleados.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }


        private void BEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
            else
            {
                int idSeleccionado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["ID"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el empleado seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (empleadoRepositorio.EliminarEmpleado(idSeleccionado))
                    {
                        MessageBox.Show("El empleado se eliminó correctamente.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarEmpleados();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el empleado.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BBuscarUsuario_Click(object sender, EventArgs e)
        {
            BReactivar.Visible = false;
            BEliminarEmpleado.Visible = false;
            if (ComboBoxBuscarDni.Text == "DNI" && TBGestionUsuario.Text != "")
            {
                //busqueda DNI
                int dni = int.Parse(TBGestionUsuario.Text);
                CargarEmpleados(dni);
            }
            else
            {
                //busqueda Nombre+Apellido
                string nom = TBGestionUsuario.Text;
                CargarEmpleados(nom);
            }
        }

        private void CargarEmpleados(int dni)
        {
            List<Modelos.Empleado> empleados = empleadoRepositorio.ListarEmpleados(dni);
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Refresh();
            foreach (Modelos.Empleado empleado in empleados)
            {
                if (empleado.Estado == true)
                {
                    dgvEmpleados.Rows.Add(empleado.Id, empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.Telefono, empleado.Direccion, empleado.Correo, empleado.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvEmpleados.Rows.Add(empleado.Id, empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.Telefono, empleado.Direccion, empleado.Correo, empleado.Estado);

                    // Establecer el color de fondo de la fila agregada
                    dgvEmpleados.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void CargarEmpleados(string nom)
        {
            List<Modelos.Empleado> empleados = empleadoRepositorio.ListarEmpleados(nom);
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Refresh();
            foreach (Modelos.Empleado empleado in empleados)
            {
                if (empleado.Estado == true)
                {
                    dgvEmpleados.Rows.Add(empleado.Id, empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.Telefono, empleado.Direccion, empleado.Correo, empleado.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvEmpleados.Rows.Add(empleado.Id, empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.Telefono, empleado.Direccion, empleado.Correo, empleado.Estado);

                    // Establecer el color de fondo de la fila agregada
                    dgvEmpleados.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void GestionarEmpleados_Load(object sender, EventArgs e)
        {
            ComboBoxBuscarDni.Text = "Nombre y Apellido";
            BReactivar.Visible = false;
            BEliminarEmpleado.Visible = false;
        }

        

        private void dgvEmpleados_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila que fue doble clickeada
                DataGridViewRow filaSeleccionada = dgvEmpleados.Rows[e.RowIndex];
                bool estadoSelect = (bool)filaSeleccionada.Cells["Estado"].Value;
                if (estadoSelect == false)
                {
                    BEliminarEmpleado.Visible = false;
                    BReactivar.Visible = true;
                }
                else
                {
                    BEliminarEmpleado.Visible = true;
                    BReactivar.Visible = false;
                }
            }


        }

        private void ComboBoxBuscarDni_SelectedValueChanged(object sender, EventArgs e)
        {
            TBGestionUsuario.Clear();
        }

        private void BReactivar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                // Obtener la fila que fue doble clickeada
                int IdSelect = (int)dgvEmpleados.SelectedRows[0].Cells["ID"].Value; ;
                if (empleadoRepositorio.ReactivaEmpleado(IdSelect))
                {
                    MessageBox.Show("Se ha reactivado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El puesto ya estaba activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CargarEmpleados();
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
