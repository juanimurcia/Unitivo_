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
using Unitivo.Presentacion.Vendedor;
using Unitivo.Repositorios.Implementaciones;
using Color = Unitivo.Modelos.Color;

namespace Unitivo.Presentacion.Administrador
{
    public partial class GestionarColores : Form
    {
        ColorRepositorio colorRepositorio = new ColorRepositorio();
        Color colorParaEditar = new Color();
        private string tipoDeColor = "";
        public GestionarColores()
        {
            InitializeComponent();
            CargarTipoColores();
        }

        private void BEliminarColor_Click(object sender, EventArgs e)
        {
            if (dgvListarColores.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            if (dgvListarColores.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el color seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idEliminar = (int)dgvListarColores.SelectedRows[0].Cells["ID"].Value;
                    if (colorRepositorio.EliminarColor(idEliminar))
                    {
                        MessageBox.Show("El color se eliminó correctamente.", "Colores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarColores();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el color.", "Colores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            // Aquí puedes agregar el código para eliminar el producto seleccionado.
        }

        private void CargarColores()
        {
            List<Color> colores = colorRepositorio.ListarColores();
            dgvListarColores.Rows.Clear();
            dgvListarColores.Refresh();

            foreach (Color color in colores)
            {
                if (color.Estado == true)
                {
                    dgvListarColores.Rows.Add(color.Id, color.Descripcion, color.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvListarColores.Rows.Add(color.Id, color.Descripcion, color.Estado);

                    // Establecer el color de fondo de la fila agregada
                    dgvListarColores.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void CargarColores(string nom)
        {
            List<Color> colores = colorRepositorio.BuscarColor(nom);
            dgvListarColores.Rows.Clear();
            dgvListarColores.Refresh();

            foreach (Color color in colores)
            {
                if (color.Estado == true)
                {
                    dgvListarColores.Rows.Add(color.Id, color.Descripcion, color.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvListarColores.Rows.Add(color.Id, color.Descripcion, color.Estado);

                    // Establecer el color de fondo de la fila agregada
                    dgvListarColores.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }


        private void BAltaColor_Click(object sender, EventArgs e)
        {

        }

        private void GestionarColores_Load(object sender, EventArgs e)
        {
            CargarColores();
            BReactivar.Visible = false;
            BEliminarColor.Visible = false;
        }

        private void BBuscarColor_Click(object sender, EventArgs e)
        {
            BReactivar.Visible = false;
            BEliminarColor.Visible = false;
            //busqueda correo+Apellido
            string nom = TBBuscarColor.Text;
            CargarColores(nom);
        }

        private void dgvListarColores_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvListarColores_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Obtener la fila que fue doble clickeada
                DataGridViewRow filaSeleccionada = dgvListarColores.Rows[e.RowIndex];
                bool estadoSelect = (bool)filaSeleccionada.Cells["Estado"].Value;
                if (estadoSelect == false)
                {
                    BEliminarColor.Visible = false;
                    BReactivar.Visible = true;
                }
                else
                {
                    BEliminarColor.Visible = true;
                    BReactivar.Visible = false;
                }
            }
        }

        private void BModificarColor_Click(object sender, EventArgs e)
        {
            if (dgvListarColores.SelectedRows.Count > 0)
            {
                string colorSeleccionado = Convert.ToString(dgvListarColores.SelectedRows[0].Cells["Descripcion"].Value);
                int idColor = (int)dgvListarColores.SelectedRows[0].Cells["ID"].Value;


                TBModColor.Text = colorSeleccionado;

                colorParaEditar.Id = idColor;
                //tipoDeColor = Convert.ToString(dgvListarColores.SelectedRows[0].Cells["TipoColor"].Value);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorParaEditar.Id != 0 && TBModColor.Text.Trim() != "")
            {
                colorParaEditar = colorRepositorio.BuscarColorPorId(colorParaEditar.Id);
                colorParaEditar.Descripcion = TBModColor.Text.Trim();

                if (colorRepositorio.ModificarColor(colorParaEditar))
                {
                    CargarColores();
                    MessageBox.Show("Se modifico con exito", "exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBModColor.Text = "";
                    colorParaEditar = new Color();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvListarColores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BReactivar_Click(object sender, EventArgs e)
        {

            if (dgvListarColores.SelectedRows.Count > 0)
            {
                // Obtener la fila que fue doble clickeada
                int IdSelect = (int)dgvListarColores.SelectedRows[0].Cells["ID"].Value; ;
                if (colorRepositorio.reactivarColor(IdSelect))
                {
                    MessageBox.Show("Se ha reactivado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El puesto ya estaba activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CargarColores();
            }
        }

        private void TBModColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tipoDeColor == "Numeros")
            {
                CommonFunctions.ValidarNumerosSinEspacios(sender, e);
            }
            else if (tipoDeColor == "Letras")
            {
                CommonFunctions.ValidarLetrasSinEspacios(sender, e);
            }
            else
            {
                CommonFunctions.ValidarKeyPress((System.Windows.Forms.TextBox)sender, e);
            }

        }

        private void TBModColor_TextChanged(object sender, EventArgs e)
        {
        }

        private void GroupBoxDatosColores_Enter(object sender, EventArgs e)
        {

        }

        private void CargarTipoColores()
        {

        }
        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tipoDeColor == "Numeros")
            {
                CommonFunctions.ValidarNumerosSinEspacios(sender, e);
            }
            else if (tipoDeColor == "Letras")
            {
                CommonFunctions.ValidarLetrasSinEspacios(sender, e);
            }
            else
            {
                CommonFunctions.ValidarKeyPress((System.Windows.Forms.TextBox)sender, e);
            }
        }

        private void CBTipoColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBTipoColor_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}