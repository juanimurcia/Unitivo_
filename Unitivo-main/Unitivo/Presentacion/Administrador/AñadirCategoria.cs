using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;
using Color = System.Drawing.Color;

namespace Unitivo.Presentacion.Administrador
{

    public partial class AñadirCategoria : Form
    {
        CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
        TipoTalleRepositorio tipoTalleRepositorio = new TipoTalleRepositorio(); // Repositorio para tipoTalle

        public AñadirCategoria()
        {
            InitializeComponent();
            CargarCategorias();
            CargarTipoTalles();

            TBNombreCategoria.Enabled = false;
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void BRegistrarCategoria_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.ValidarCamposNoVacios(this))
            {
                Categoria categoria = new Categoria();
                categoria.Descripcion = TBNombreCategoria.Text.Trim();

                if (CBTipoTalle.SelectedItem != null)
                {
                    categoria.TipoTalleId = ((TipoTalle)CBTipoTalle.SelectedItem).Id; // Guardar el ID de tipoTalle
                }

                if (CBTipoTalle.SelectedItem != null && categoriaRepositorio.AgregarCategoria(categoria))
                {
                    MessageBox.Show("Categoria agregada correctamente");
                    LimpiarTextBoxs();
                    CargarCategorias();
                }
                else
                {
                    MessageBox.Show("Error al agregar Categoria");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos y seleccionar un tipo de talle válido", "Talle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarTipoTalles()
        {
            var tipoTalles = tipoTalleRepositorio.ListarTipoTalles();

            CBTipoTalle.Items.Clear();
            CBTipoTalle.Items.Add("Seleccione un tipo de talle");
            CBTipoTalle.Items.AddRange(tipoTalles.ToArray());
            CBTipoTalle.ValueMember = "Id";
            CBTipoTalle.DisplayMember = "Descripcion";
            CBTipoTalle.SelectedIndex = 0; // Seleccionar el texto inicial

        }


        private void CargarCategorias()
        {
            List<Categoria> categorias = categoriaRepositorio.ListarCategoriasActivos();
            DataGridViewListarCategorias.Rows.Clear();
            DataGridViewListarCategorias.Refresh();

            foreach (Categoria categoria in categorias)
            {
                if (categoria.Estado == true)
                {
                    DataGridViewListarCategorias.Rows.Add(categoria.Id, categoria.Descripcion, categoria.Estado, categoria.TipoTalleIdNavigation.Descripcion);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListarCategorias.Rows.Add(categoria.Id, categoria.Descripcion, categoria.Estado, categoria.TipoTalleIdNavigation.Descripcion);

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListarCategorias.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        // Método para limpiar los TextBox después de agregar un perfil.
        private void LimpiarTextBoxs()
        {
            TBNombreCategoria.Clear();
        }

        private void AñadirCategoria_Load(object sender, EventArgs e)
        {

        }

        private void CBTipoTalle_SelectedIndexChanged(object sender, EventArgs e)
        {

            TBNombreCategoria.Clear();
            if (CBTipoTalle.SelectedIndex > 0)
            {
                TBNombreCategoria.Enabled = true; // Habilitar el TextBox si se selecciona un tipo de talle válido
                //tipoDeTalle = ((TipoTalle)CBTipoTalle.SelectedItem).Descripcion; // Guardar la descripcion de tipoTalle
            }
            else
            {
                TBNombreCategoria.Enabled = false; // Deshabilitar el TextBox si no se selecciona un tipo de talle válido
                TBNombreCategoria.Clear(); // Limpiar el TextBox
            }

        }

        private void PanelRegCategoria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
