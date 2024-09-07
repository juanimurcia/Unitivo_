using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class AñadirUsuario : Form
    {
        EmpleadoRepositorio empleadoRepositorio = new EmpleadoRepositorio();
        UsuariosRepositorio usuarioRepositorio = new UsuariosRepositorio();
        PerfilRepositorio perfilRepositorio = new PerfilRepositorio();


        public AñadirUsuario()
        {
            InitializeComponent();
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarEmailKeyPress((TextBox)sender, e);
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarPassword((TextBox)sender, e);
        }

        private void BRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (!VerificarCamposVacios())
            {
                // Mostrar un mensaje de error si algún campo está vacío o si no se ha seleccionado un perfil.
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos y seleccione un perfil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TBContraseñaUsuario.Text != TBConfirmarPass.Text)
                {
                    MessageBox.Show("El password y el re-password deben coincidir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Usuario x = new Usuario();

                    x.NombreUsuario = TBNombreUsuario.Text;
                    x.Password = TBContraseñaUsuario.Text;
                    x.IdEmpleado = int.Parse(TBEmpleado.Text);
                    x.IdPerfil = (int)CBPerfil.SelectedValue;

                    if (usuarioRepositorio!.AgregarUsuario(x))
                    {
                        MessageBox.Show("Usuario " + x.NombreUsuario + " agregado con exito!", "Exito", MessageBoxButtons.OK);
                        LimpiarTextBoxs();
                        CargarEmpleados();
                        CargarUsuarios();
                        // CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Hubo problemas para agregar al usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
              
            }
        }

        // Método para limpiar los TextBox después de registrar un usuario.
        private void LimpiarTextBoxs()
        {
            TBNombreUsuario.Clear();
            TBContraseñaUsuario.Clear();
            TBConfirmarPass.Clear();
            TBEmpleado.Clear();
        }

        private void CargarEmpleados()
        {
            List<Empleado> empleados = empleadoRepositorio!.ListarEmpleadosActivos();

            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Refresh();
            foreach (Empleado empleado in empleados)
            {
                dgvEmpleados.Rows.Add(empleado.Id, empleado.Nombre, empleado.Apellido, empleado.Correo);
            }
        }

        private void CargarUsuarios()
        {
            List<Usuario> usuarios = usuarioRepositorio!.ListarUsuariosActivos();

            dgvListaUsuarios.Rows.Clear();
            dgvListaUsuarios.Refresh();

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Estado == true)
                {
                    dgvListaUsuarios.Rows.Add(usuario.Id, usuario.IdPerfilNavigation.DescripcionPerfil, usuario.NombreUsuario, usuario.IdEmpleadoNavigation.Nombre, usuario.IdEmpleadoNavigation.Apellido, usuario.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvListaUsuarios.Rows.Add(usuario.Id, usuario.IdPerfilNavigation.DescripcionPerfil, usuario.NombreUsuario, usuario.IdEmpleadoNavigation.Nombre, usuario.IdEmpleadoNavigation.Apellido, usuario.Estado);

                    // Establecer el color de fondo de la fila agregada
                    dgvListaUsuarios.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }


        private bool VerificarCamposVacios()
        {
            if (
                CommonFunctions.ValidarCamposNoVacios(TBNombreUsuario) ||
                CommonFunctions.ValidarCamposNoVacios(TBContraseñaUsuario) ||
                CommonFunctions.ValidarCamposNoVacios(TBConfirmarPass) ||
                CommonFunctions.ValidarCamposNoVacios(TBEmpleado) ||
                CBPerfil.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dgvEmpleados_CellContentDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene el valor de la celda en la fila seleccionada.
                string correoEmpleado = dgvEmpleados.Rows[e.RowIndex].Cells["Email"].Value.ToString()!;
                int idEmpleado = Convert.ToInt32(dgvEmpleados.Rows[e.RowIndex].Cells["ID"].Value);


                // Carga el valor en el TextBox.
                TBNombreUsuario.Text = correoEmpleado;
                TBEmpleado.Text = idEmpleado.ToString();
            }
        }

        private void AñadirUsuario_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarUsuarios();
            var perfiles = perfilRepositorio.ListarPerfiles();
            CBPerfil.DataSource = perfiles;
            CBPerfil.ValueMember = "Id";
            CBPerfil.DisplayMember = "DescripcionPerfil";
        }

        private void dgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
