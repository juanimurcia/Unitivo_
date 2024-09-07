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
using Color = System.Drawing.Color;

namespace Unitivo.Presentacion.Administrador
{
    public partial class GestionarTalles : Form
    {
        TalleRepositorio talleRepositorio = new TalleRepositorio();
        TipoTalleRepositorio tipoTalleRepositorio = new TipoTalleRepositorio();
        Talle talleParaEditar = new Talle();
        private string tipoDeTalle = "";
        public GestionarTalles()
        {
            InitializeComponent();
            CargarTipoTalles();
        }

        private void BEliminarTalle_Click(object sender, EventArgs e)
        {
            if (dgvListarTalles.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un talle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            if (dgvListarTalles.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el talle seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idEliminar = (int)dgvListarTalles.SelectedRows[0].Cells["ID"].Value;
                    if (talleRepositorio.EliminarTalle(idEliminar))
                    {
                        MessageBox.Show("El talle se eliminó correctamente.", "Talles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTalles();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el talle.", "Talles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            // Aquí puedes agregar el código para eliminar el producto seleccionado.
        }

        private void CargarTalles()
        {
            List<Talle> talles = talleRepositorio.ListarTalles();
            dgvListarTalles.Rows.Clear();
            dgvListarTalles.Refresh();

            foreach (Talle talle in talles)
            {
                if (talle.Estado == true)
                {
                    dgvListarTalles.Rows.Add(talle.Id, talle.Descripcion, talle.Estado, talle.TipoTalleIdNavigation.Descripcion);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvListarTalles.Rows.Add(talle.Id, talle.Descripcion, talle.Estado, talle.TipoTalleIdNavigation.Descripcion);

                    // Establecer el color de fondo de la fila agregada
                    dgvListarTalles.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void CargarTalles(string nom)
        {
            List<Talle> talles = talleRepositorio.BuscarTalle(nom);
            dgvListarTalles.Rows.Clear();
            dgvListarTalles.Refresh();

            foreach (Talle talle in talles)
            {
                if (talle.Estado == true)
                {
                    dgvListarTalles.Rows.Add(talle.Id, talle.Descripcion, talle.Estado, talle.TipoTalleIdNavigation.Descripcion);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvListarTalles.Rows.Add(talle.Id, talle.Descripcion, talle.Estado, talle.TipoTalleIdNavigation.Descripcion);

                    // Establecer el color de fondo de la fila agregada
                    dgvListarTalles.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }


        private void BAltaTalle_Click(object sender, EventArgs e)
        {

        }

        private void GestionarTalles_Load(object sender, EventArgs e)
        {
            CargarTalles();
            BReactivar.Visible = false;
            BEliminarTalle.Visible = false;
        }

        private void BBuscarTalle_Click(object sender, EventArgs e)
        {
            BReactivar.Visible = false;
            BEliminarTalle.Visible = false;
            //busqueda correo+Apellido
            string nom = TBBuscarTalle.Text;
            CargarTalles(nom);
        }

        private void dgvListarTalles_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvListarTalles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Obtener la fila que fue doble clickeada
                DataGridViewRow filaSeleccionada = dgvListarTalles.Rows[e.RowIndex];
                bool estadoSelect = (bool)filaSeleccionada.Cells["Estado"].Value;
                if (estadoSelect == false)
                {
                    BEliminarTalle.Visible = false;
                    BReactivar.Visible = true;
                }
                else
                {
                    BEliminarTalle.Visible = true;
                    BReactivar.Visible = false;
                }
            }
        }

        private void BModificarTalle_Click(object sender, EventArgs e)
        {
            if (dgvListarTalles.SelectedRows.Count > 0)
            {
                string talleSeleccionado = Convert.ToString(dgvListarTalles.SelectedRows[0].Cells["Descripcion"].Value);
                int idTalle = (int)dgvListarTalles.SelectedRows[0].Cells["ID"].Value;


                TBModTalle.Text = talleSeleccionado;

                talleParaEditar.Id = idTalle;
                tipoDeTalle = Convert.ToString(dgvListarTalles.SelectedRows[0].Cells["TipoTalle"].Value);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (talleParaEditar.Id != 0 && TBModTalle.Text.Trim() != "")
            {
                talleParaEditar = talleRepositorio.BuscarTallePorId(talleParaEditar.Id);
                talleParaEditar.Descripcion = TBModTalle.Text.Trim();

                if (talleRepositorio.ModificarTalle(talleParaEditar))
                {
                    CargarTalles();
                    MessageBox.Show("Se modifico con exito", "exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBModTalle.Text = "";
                    talleParaEditar = new Talle();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvListarTalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BReactivar_Click(object sender, EventArgs e)
        {

            if (dgvListarTalles.SelectedRows.Count > 0)
            {
                // Obtener la fila que fue doble clickeada
                int IdSelect = (int)dgvListarTalles.SelectedRows[0].Cells["ID"].Value; ;
                if (talleRepositorio.reactivarTalle(IdSelect))
                {
                    MessageBox.Show("Se ha reactivado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El puesto ya estaba activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CargarTalles();
            }
        }

        private void TBModTalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tipoDeTalle == "Numeros")
            {
                CommonFunctions.ValidarNumerosSinEspacios(sender, e);
            }
            else if (tipoDeTalle == "Letras")
            {
                CommonFunctions.ValidarLetrasSinEspacios(sender, e);
            }
            else
            {
                CommonFunctions.ValidarKeyPress((System.Windows.Forms.TextBox)sender, e);
            }

        }

        private void TBModTalle_TextChanged(object sender, EventArgs e)
        {
        }

        private void GroupBoxDatosTalles_Enter(object sender, EventArgs e)
        {

        }

        private void CargarTipoTalles()
        {

        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tipoDeTalle == "Numeros")
            {
                CommonFunctions.ValidarNumerosSinEspacios(sender, e);
            }
            else if (tipoDeTalle == "Letras")
            {
                CommonFunctions.ValidarLetrasSinEspacios(sender, e);
            }
            else
            {
                CommonFunctions.ValidarKeyPress((System.Windows.Forms.TextBox)sender, e);
            }
        }

        private void CBTipoTalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBTipoTalle_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}