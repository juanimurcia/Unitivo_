using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;
using Color = System.Drawing.Color;
namespace Unitivo.Presentacion.Administrador
{
    public partial class AñadirProducto : Form
    {
        private ProductoRepositorio productoRepositorio = new ProductoRepositorio();
        private CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
        private TalleRepositorio talleRepositorio = new TalleRepositorio();
        private ColorRepositorio colorRepositorio = new ColorRepositorio();

        private string? rutaImagenProducto;
        private Image? image;

        public AñadirProducto()
        {
            InitializeComponent();
        }

        private void AñadirProducto_Load(object sender, EventArgs e)
        {

            cargarCategorias();
            cargarTalles();
            CargarColores();
            CargarProductos();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void Num_DecimalKeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarDecimalKeyPress((TextBox)sender, e);
        }

        private void CargarProductos()
        {
            List<Producto> productos = productoRepositorio.ListarProductosActivos();
            DataGridViewListaProductos.Rows.Clear();
            DataGridViewListaProductos.Refresh();
            foreach (Producto producto in productos)
            {
                if (producto.Estado == true)
                {
                    DataGridViewListaProductos.Rows.Add(producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.IdTalleNavigation.Descripcion, producto.IdColorNavigation.Descripcion, producto.Stock, producto.Precio, producto.Descripcion, producto.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListaProductos.Rows.Add(producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.IdTalleNavigation.Descripcion, producto.IdColorNavigation.Descripcion, producto.Stock, producto.Precio, producto.Descripcion   , producto.Estado);

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListaProductos.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void BAñadirProducto_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.ValidarCamposNoVacios(this) && CBCategoria.Text != "" && CBColor.Text != "" && CBTalle.Text != "" && !(TBPrecio.Text.Trim().Contains(".") && TBPrecio.Text.Trim().Split('.')[1].Length > 2))
            {
                Producto producto = new Producto();
                producto.Nombre = TBNombreProducto.Text.Trim();
                producto.IdCategoria = (int)CBCategoria.SelectedValue!;
                producto.Stock = int.Parse(TBStock.Text.Trim());
                producto.Precio = decimal.Parse(TBPrecio.Text.Trim());
                producto.IdTalle = (int)CBTalle.SelectedValue!;
                producto.Descripcion = TBDescripcion.Text.Trim();
                producto.IdColor = (int)CBColor.SelectedValue!;

                if (productoRepositorio!.AgregarProducto(producto))
                {
                    MessageBox.Show("Producto agregado correctamente.");
                    LimpiarTextBoxs();
                    cargarCategorias();
                    cargarTalles();
                    CargarProductos();
                }
                else
                {
                    MessageBox.Show("Error al agregar el Producto.");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaImagenProducto = openFileDialog.FileName;
                    //pictureBoxProducto.Image = Image.FromFile(rutaImagenProducto);
                    image!.Save(rutaImagenProducto);
                }
            }
        }

        private void LimpiarTextBoxs()
        {
            TBNombreProducto.Text = "";
            TBPrecio.Text = "";
            TBStock.Text = "";
            CBCategoria.SelectedValue = 0;
            CBTalle.SelectedValue = 0;
            TBDescripcion.Text = "";
        }

        private void cargarTalles()
        {

            var talles = talleRepositorio.ListarTallesActivos();
            CBTalle.DataSource = talles;
            CBTalle.ValueMember = "Id";
            CBTalle.DisplayMember = "Descripcion";
            CBTalle.Text = "Seleccione un talle";
            CBTalle.SelectedValue = -1;
        }

        private void cargarCategorias()
        {
            var categorias = categoriaRepositorio.ListarCategoriasActivos();
            CBCategoria.DataSource = categorias;
            CBCategoria.ValueMember = "Id";
            CBCategoria.DisplayMember = "Descripcion";

            CBTalle.Enabled = false;
        }
        private void CargarColores()
        {
            var colores = colorRepositorio.ListarColoresActivos();
            CBColor.DataSource = colores;
            CBColor.ValueMember = "Id";
            CBColor.DisplayMember = "Descripcion";

        }



        private void DataGridViewListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CBCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CBCategoria.SelectedValue is int categoriaId)
            {
                var categoria = categoriaRepositorio.BuscarCategoriaPorId(categoriaId);
                if (categoria != null)
                {
                    CBTalle.Enabled = true;
                    var tallesFiltrados = talleRepositorio.ListarTallesPorTipo(categoria.TipoTalleId);
                    CBTalle.DataSource = tallesFiltrados;
                }
            }
        }

        private void CBTalle_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void CBTalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TBNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabPageListaProducto_Click(object sender, EventArgs e)
        {

        }
    }
}

