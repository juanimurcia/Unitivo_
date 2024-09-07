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
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Administrador
{
    public partial class GestionarCategorias : Form
    {
        CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
        TipoTalleRepositorio tipoTalleRepositorio = new TipoTalleRepositorio();
        Categoria categoriaParaEditar = new Categoria();
        public GestionarCategorias()
        {
            InitializeComponent();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }


        private void BEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvRegistroCategoria.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar una categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            if (dgvRegistroCategoria.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la categoria seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idEliminar = (int)dgvRegistroCategoria.SelectedRows[0].Cells["ID"].Value;
                    if (categoriaRepositorio.EliminarCategoria(idEliminar))
                    {
                        MessageBox.Show("la categoria se eliminó correctamente.", "categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCategorias();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar la categoria.", "categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            // Aquí puedes agregar el código para eliminar el producto seleccionado.
        }

        private void BBuscarCategoria_Click(object sender, EventArgs e)
        {
            //busqueda correo+Apellido
            string nom = TBGestionCategoria.Text;
            CargarCategorias(nom);
            BReactivar.Visible = false;
            BEliminarCategoria.Visible = false;
        }

        private void GestionarCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarTipoTalles();
            BReactivar.Visible = false;
            BEliminarCategoria.Visible = false;
        }

        private void CargarCategorias()
        {
            List<Categoria> categorias = categoriaRepositorio.ListarCategorias();
            dgvRegistroCategoria.Rows.Clear();
            dgvRegistroCategoria.Refresh();

            foreach (Categoria categoria in categorias)
            {
                if (categoria.Estado == true)
                {
                    dgvRegistroCategoria.Rows.Add(categoria.Id, categoria.Descripcion, categoria.Estado, categoria.TipoTalleIdNavigation.Descripcion);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvRegistroCategoria.Rows.Add(categoria.Id, categoria.Descripcion, categoria.Estado, categoria.TipoTalleIdNavigation.Descripcion);

                    // Establecer el color de fondo de la fila agregada
                    dgvRegistroCategoria.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void CargarCategorias(string nom)
        {
            List<Categoria> categorias = categoriaRepositorio.BuscarCategoria(nom);
            dgvRegistroCategoria.Rows.Clear();
            dgvRegistroCategoria.Refresh();

            foreach (Categoria categoria in categorias)
            {
                if (categoria.Estado == true)
                {
                    dgvRegistroCategoria.Rows.Add(categoria.Id, categoria.Descripcion, categoria.Estado, categoria.TipoTalleIdNavigation.Descripcion);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvRegistroCategoria.Rows.Add(categoria.Id, categoria.Descripcion, categoria.Estado, categoria.TipoTalleIdNavigation.Descripcion);

                    // Establecer el color de fondo de la fila agregada
                    dgvRegistroCategoria.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }

        }

        private void BModificarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvRegistroCategoria.SelectedRows.Count > 0)
            {
                string categoriaSeleccionado = Convert.ToString(dgvRegistroCategoria.SelectedRows[0].Cells["Descripcion"].Value);
                int idCategoria = (int)dgvRegistroCategoria.SelectedRows[0].Cells["ID"].Value;

                TBNombreCategoria.Text = categoriaSeleccionado;

                categoriaParaEditar.Id = idCategoria;

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
        }

        private void dgvRegistroCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRegistroCategoria_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila que fue doble clickeada
                DataGridViewRow filaSeleccionada = dgvRegistroCategoria.Rows[e.RowIndex];
                bool estadoSelect = (bool)filaSeleccionada.Cells["Estado"].Value;
                if (estadoSelect == false)
                {
                    BEliminarCategoria.Visible = false;
                    BReactivar.Visible = true; ;
                }
                else
                {
                    BEliminarCategoria.Visible = true;
                    BReactivar.Visible = false;

                }
            }
        }

        private void dgvRegistroCategoria_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (categoriaParaEditar.Id != 0 && TBNombreCategoria.Text.Trim() != "")
            {
                categoriaParaEditar = categoriaRepositorio.BuscarCategoriaPorId(categoriaParaEditar.Id);
                categoriaParaEditar.Descripcion = TBNombreCategoria.Text.Trim();



                if (categoriaRepositorio.ModificarCategoria(categoriaParaEditar))
                {
                    CargarCategorias();
                    MessageBox.Show("Se modifico con exito", "exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBNombreCategoria.Text = "";
                    categoriaParaEditar = new Categoria();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvRegistroCategoria.SelectedRows.Count > 0)
            {
                // Obtener la fila que fue doble clickeada
                int IdSelect = (int)dgvRegistroCategoria.SelectedRows[0].Cells["ID"].Value; ;
                if (categoriaRepositorio.reactivarCategoria(IdSelect))
                {
                    MessageBox.Show("Se ha reactivado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El puesto ya estaba activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CargarCategorias();
            }
        }

        private void CargarTipoTalles()
        {

        }

        private void BAltaCategoria_Click(object sender, EventArgs e)
        {

        }

        private void BAltaCategoria_Click_1(object sender, EventArgs e)
        {

        }
    }
}
