using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class GestionarUsuarios : Form
    {
        EmpleadoRepositorio empleadoRepositorio = new EmpleadoRepositorio();
        UsuariosRepositorio usuarioRepositorio = new UsuariosRepositorio();
        PerfilRepositorio perfilRepositorio = new PerfilRepositorio();
        Usuario usuarioParaEditar = new Usuario();
        public GestionarUsuarios()
        {
            InitializeComponent();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }


        private void BEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvListaUsuarios.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            if (dgvListaUsuarios.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el usuario seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idEliminar = (int)dgvListaUsuarios.SelectedRows[0].Cells["ID"].Value;
                    if (usuarioRepositorio.EliminarUsuario(idEliminar))
                    {
                        MessageBox.Show("El usuario se eliminó correctamente.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            // Aquí puedes agregar el código para eliminar el producto seleccionado.
        }

        private void GestionarUsuarios_Load(object sender, EventArgs e)
        {
            cargarPerfiles();
            cargarUsuarios();
            BReactivar.Visible = false;
            BEliminarUsuario.Visible = false;
        }

        private void BBuscarUsuario_Click(object sender, EventArgs e)
        {
            //busqueda correo+Apellido
            string nom = TBGestionUsuario.Text;
            cargarUsuarios(nom);
            BReactivar.Visible = false;
            BEliminarUsuario.Visible = false;
        }

        private void cargarUsuarios()
        {
            List<Usuario> usuarios = usuarioRepositorio!.ListarUsuarios();

            dgvListaUsuarios.Rows.Clear();
            dgvListaUsuarios.Refresh();

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Estado == true)
                {
                    dgvListaUsuarios.Rows.Add(usuario.Id, usuario.NombreUsuario, usuario.Estado, usuario.IdEmpleadoNavigation.FechaModificacion, usuario.IdEmpleadoNavigation.FechaCreacion, usuario.IdPerfilNavigation.DescripcionPerfil, usuario.IdEmpleadoNavigation.Apellido);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvListaUsuarios.Rows.Add(usuario.Id, usuario.NombreUsuario, usuario.Estado, usuario.IdEmpleadoNavigation.FechaModificacion, usuario.IdEmpleadoNavigation.FechaCreacion, usuario.IdPerfilNavigation.DescripcionPerfil, usuario.IdEmpleadoNavigation.Apellido);

                    // Establecer el color de fondo de la fila agregada
                    dgvListaUsuarios.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void cargarUsuarios(string nom)
        {
            List<Usuario> usuarios = usuarioRepositorio!.BuscarUsuario(nom);

            dgvListaUsuarios.Rows.Clear();
            dgvListaUsuarios.Refresh();

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Estado == true)
                {
                    dgvListaUsuarios.Rows.Add(usuario.Id, usuario.NombreUsuario, usuario.Estado, usuario.IdEmpleadoNavigation.FechaModificacion, usuario.IdEmpleadoNavigation.FechaCreacion, usuario.IdPerfilNavigation.DescripcionPerfil, usuario.IdEmpleadoNavigation.Apellido);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvListaUsuarios.Rows.Add(usuario.Id, usuario.NombreUsuario, usuario.Estado, usuario.IdEmpleadoNavigation.FechaModificacion, usuario.IdEmpleadoNavigation.FechaCreacion, usuario.IdPerfilNavigation.DescripcionPerfil, usuario.IdEmpleadoNavigation.Apellido);

                    // Establecer el color de fondo de la fila agregada
                    dgvListaUsuarios.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void BModificarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvListaUsuarios.SelectedRows.Count > 0)
            {
                string usuarioSeleccionado = Convert.ToString(dgvListaUsuarios.SelectedRows[0].Cells["Nombre"].Value);
                int idUsuario = (int)dgvListaUsuarios.SelectedRows[0].Cells["ID"].Value;

                TBNombreUsuario.Text = usuarioSeleccionado;
                ComboBoxPerfil.SelectedValue = usuarioRepositorio.BuscarUsuarioPorId(idUsuario).IdPerfil;

                usuarioParaEditar.Id = idUsuario;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
        }

        private void cargarPerfiles()
        {
            var perfiles = perfilRepositorio.ListarPerfiles();
            ComboBoxPerfil.DataSource = perfiles;
            ComboBoxPerfil.ValueMember = "Id";
            ComboBoxPerfil.DisplayMember = "DescripcionPerfil";
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            TBContraseñaUsuario.Text = "";
            TBNombreUsuario.Text = "";
            usuarioParaEditar = new Usuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuarioParaEditar.Id != 0 && TBNombreUsuario.Text != "")
            {
                usuarioParaEditar = usuarioRepositorio.BuscarUsuarioPorId(usuarioParaEditar.Id);
                usuarioParaEditar.NombreUsuario = TBNombreUsuario.Text;
                usuarioParaEditar.IdPerfil = (int)ComboBoxPerfil.SelectedValue;
                usuarioParaEditar.Password = TBContraseñaUsuario.Text;
                if (usuarioRepositorio.ModificarUsuario(usuarioParaEditar))
                {
                    cargarUsuarios();
                    MessageBox.Show("Se modifico con exito", "exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBContraseñaUsuario.Text = "";
                    TBNombreUsuario.Text = "";
                    usuarioParaEditar = new Usuario();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvListaUsuarios_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila que fue doble clickeada
                DataGridViewRow filaSeleccionada = dgvListaUsuarios.Rows[e.RowIndex];
                int IdSelect = (int)filaSeleccionada.Cells["ID"].Value;
                if (usuarioRepositorio.reactivarUsuario(IdSelect))
                {
                    MessageBox.Show("Se ha reactivado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El puesto ya estaba activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                cargarUsuarios();
            }
        }

        private void dgvListaUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Obtener la fila que fue doble clickeada
                DataGridViewRow filaSeleccionada = dgvListaUsuarios.Rows[e.RowIndex];
                bool estadoSelect = (bool)filaSeleccionada.Cells["Estado"].Value;
                if (estadoSelect == false)
                {
                    BEliminarUsuario.Visible = false;
                    BReactivar.Visible = true;
                }
                else
                {
                    BEliminarUsuario.Visible = true;
                    BReactivar.Visible = false;
                }
            }
        }

        private void dgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BReactivar_Click(object sender, EventArgs e)
        {

            if (dgvListaUsuarios.SelectedRows.Count > 0)
            {
                // Obtener la fila que fue doble clickeada
                int IdSelect = (int)dgvListaUsuarios.SelectedRows[0].Cells["ID"].Value; ;
                if (usuarioRepositorio.reactivarUsuario(IdSelect))
                {
                    MessageBox.Show("Se ha reactivado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El puesto ya estaba activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                cargarUsuarios();
            }
        }
    }
}
