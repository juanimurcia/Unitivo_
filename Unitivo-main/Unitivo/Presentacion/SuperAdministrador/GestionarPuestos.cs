using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class GestionarPuestos : Form
    {
        PerfilRepositorio perfilRepositorio = new PerfilRepositorio();
        Perfile perfilParaEditar = new Perfile();
        public GestionarPuestos()
        {
            InitializeComponent();

        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void BEliminarPerfiles_Click(object sender, EventArgs e)
        {
            if (DataGridViewListarPerfiles.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un puesto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            if (DataGridViewListarPerfiles.SelectedRows.Count > 0)
            {
                int idEliminar = (int)DataGridViewListarPerfiles.SelectedRows[0].Cells["ID"].Value;

                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el puesto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (perfilRepositorio.EliminarPerfil(idEliminar))
                    {
                        MessageBox.Show("El puesto se eliminó correctamente.", "Puesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPerfiles();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el puesto.", "Puesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CargarPerfiles()
        {
            List<Perfile> perfiles = perfilRepositorio.ListarPerfiles();
            DataGridViewListarPerfiles.Rows.Clear();
            DataGridViewListarPerfiles.Refresh();
            foreach (Perfile perfile in perfiles)
            {

                if (perfile.EstadoPerfil == true)
                {
                    DataGridViewListarPerfiles.Rows.Add(perfile.Id, perfile.DescripcionPerfil, perfile.EstadoPerfil);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListarPerfiles.Rows.Add(perfile.Id, perfile.DescripcionPerfil, perfile.EstadoPerfil); ;

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListarPerfiles.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }

            }

        }

        // Método para limpiar los TextBox después de agregar un perfil.
        private void LimpiarTextBoxs()
        {
            TBGestionPerfil.Clear();
        }

        private void GestionarPuestos_Load(object sender, EventArgs e)
        {
            CargarPerfiles();
            BReactivar.Visible = false;
            BEliminarPerfiles.Visible = false;
        }

        private void BBuscarPerfil_Click(object sender, EventArgs e)
        {
            CargarPerfiles(perfilRepositorio.BuscarPerfil(TBGestionPerfil.Text));
            BReactivar.Visible = false;
            BEliminarPerfiles.Visible = false;
        }

        private void CargarPerfiles(List<Perfile> nuevosPerfiles)
        {
            List<Perfile> perfiles = nuevosPerfiles;
            DataGridViewListarPerfiles.Rows.Clear();
            DataGridViewListarPerfiles.Refresh();
            foreach (Perfile perfile in perfiles)
            {

                if (perfile.EstadoPerfil == true)
                {
                    DataGridViewListarPerfiles.Rows.Add(perfile.Id, perfile.DescripcionPerfil, perfile.EstadoPerfil);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListarPerfiles.Rows.Add(perfile.Id, perfile.DescripcionPerfil, perfile.EstadoPerfil); ;

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListarPerfiles.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }


        }

        private void BModificarPerfiles_Click(object sender, EventArgs e)
        {
            if (DataGridViewListarPerfiles.SelectedRows.Count > 0)
            {
                string PuestoSeleccionado = Convert.ToString(DataGridViewListarPerfiles.SelectedRows[0].Cells["Descripcion"].Value);

                TBModPerfil.Text = PuestoSeleccionado;

                perfilParaEditar.Id = Convert.ToInt32(DataGridViewListarPerfiles.SelectedRows[0].Cells["ID"].Value);
                perfilParaEditar.DescripcionPerfil = PuestoSeleccionado;
                perfilParaEditar.EstadoPerfil = (bool)DataGridViewListarPerfiles.SelectedRows[0].Cells["Estado"].Value;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
        }

        private void BModEmpleado_Click(object sender, EventArgs e)
        {
            if (perfilParaEditar.Id != 0 && TBModPerfil.Text.Trim() != "")
            {
                perfilParaEditar.DescripcionPerfil = TBModPerfil.Text;
                perfilRepositorio.ModificarPerfil(perfilParaEditar);
                perfilParaEditar = new Perfile();
                CargarPerfiles();
                TBModPerfil.Text = "";
            }
            else
            {
                MessageBox.Show("El campo puesto no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void DataGridViewListarPerfiles_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila que fue doble clickeada
                DataGridViewRow filaSeleccionada = DataGridViewListarPerfiles.Rows[e.RowIndex];
                int IdSelect = (int)filaSeleccionada.Cells["ID"].Value;
                if (perfilRepositorio.ReactivarPerfil(IdSelect))
                {
                    MessageBox.Show("Se ha reactivado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El puesto ya estaba activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CargarPerfiles();
            }
        }

        private void DataGridViewListarPerfiles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Obtener la fila que fue doble clickeada
                DataGridViewRow filaSeleccionada = DataGridViewListarPerfiles.Rows[e.RowIndex];
                bool estadoSelect = (bool)filaSeleccionada.Cells["Estado"].Value;
                if (estadoSelect == false)
                {
                    BEliminarPerfiles.Visible = false;
                    BReactivar.Visible = true;
                }
                else
                {
                    BEliminarPerfiles.Visible = true;
                    BReactivar.Visible = false;
                }
            }
        }

        private void DataGridViewListarPerfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            perfilParaEditar = new Perfile();
            TBModPerfil.Text = "";
        }

        private void BReactivar_Click(object sender, EventArgs e)
        {
            if (DataGridViewListarPerfiles.SelectedRows.Count > 0)
            {
                // Obtener la fila que fue doble clickeada
                int IdSelect = (int)DataGridViewListarPerfiles.SelectedRows[0].Cells["ID"].Value; ;
                if (perfilRepositorio.ReactivarPerfil(IdSelect))
                {
                    MessageBox.Show("Se ha reactivado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El puesto ya estaba activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CargarPerfiles();
            }


        }
    }
}
