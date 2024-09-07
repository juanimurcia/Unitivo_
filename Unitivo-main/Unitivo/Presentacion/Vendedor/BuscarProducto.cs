using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Formularios.Vendedor;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Vendedor
{
    public partial class BuscarProducto : Form
    {
        private AñadirVentas AddVenta;
        private Producto productoVenta = new Producto();
        private ProductoRepositorio productoRepositorio = new ProductoRepositorio();
        private CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
        private ColorRepositorio colorRepositorio = new ColorRepositorio();
        private TalleRepositorio talleRepositorio = new TalleRepositorio();
        private Producto productoParaEditar = new Producto();

        public BuscarProducto(AñadirVentas NVenta)
        {
            InitializeComponent();
            AddVenta = NVenta;
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BSeleccionar_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaProductos.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para seleccionar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
            else
            {
                // Obtén el ID del cliente seleccionado
                int idSeleccionado = Convert.ToInt32(DataGridViewListaProductos.SelectedRows[0].Cells["ID"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro que desea utilizar el producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Producto prod = productoRepositorio.BuscarProducto(idSeleccionado);
                    AddVenta.UtilizarProducto(prod);
                    Close();
                    return;
                }
            }
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            cargarTalles();
            cargarColores();
            CargarProductos();
        }

        private void cargarCategorias()
        {
            var categorias = categoriaRepositorio.ListarCategoriasActivos();
            categorias.Insert(0, new Categoria { Id = 0, Descripcion = "Todos" }); // Agregar la opción "Todos"
            CBCategoria.DataSource = categorias;
            CBCategoria.DisplayMember = "Descripcion";
            CBCategoria.ValueMember = "Id";

            // Añadir el evento SelectedIndexChanged
            CBCategoria.SelectedIndexChanged += CBCategoria_SelectedIndexChanged;
        }

        private void cargarColores()
        {
            var colores = colorRepositorio.ListarColoresActivos();
            colores.Insert(0, new Modelos.Color { Id = 0, Descripcion = "Todos" }); // Agregar la opción "Todos"
            CBColor.DataSource = colores;
            CBColor.DisplayMember = "Descripcion";
            CBColor.ValueMember = "Id";

        }

        private void cargarTalles()
        {
            var talles = talleRepositorio.ListarTallesActivos();
            talles.Insert(0, new Talle { Id = 0, Descripcion = "Todos" }); // Agregar la opción "Todos"
            CBTalle.DataSource = talles;
            CBTalle.ValueMember = "Id";
            CBTalle.DisplayMember = "Descripcion";

        }

        private void CargarProductos()
        {
            List<Producto> productos = productoRepositorio.ListarProductosActivosVentas();
            DataGridViewListaProductos.Rows.Clear();
            DataGridViewListaProductos.Refresh();
            foreach (Producto producto in productos)
            {
                if (producto.Estado == true)
                {
                    DataGridViewListaProductos.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.IdTalleNavigation.Descripcion, producto.IdColorNavigation.Descripcion, producto.Descripcion, producto.Stock, producto.Precio, producto.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListaProductos.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.IdTalleNavigation.Descripcion, producto.IdColorNavigation.Descripcion, producto.Descripcion, producto.Stock, producto.Precio, producto.Estado);

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListaProductos.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void CargarProductos(string nom, string cat, string talle, string color)
        {
            if (cat == "Todos")
            {
                cat = "";
            }
            if (talle == "Todos")
            {
                talle = "";
            }
            if (color == "Todos")
            {
                color = "";
            }
            List<Producto> productos = productoRepositorio.BuscarProductosActivosVentas(nom, cat, talle, color);
            DataGridViewListaProductos.Rows.Clear();
            DataGridViewListaProductos.Refresh();
            foreach (Producto producto in productos)
            {
                if (producto.Estado == true)
                {
                    DataGridViewListaProductos.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.IdTalleNavigation.Descripcion, producto.IdColorNavigation.Descripcion, producto.Descripcion, producto.Stock, producto.Precio, producto.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListaProductos.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.IdTalleNavigation.Descripcion, producto.IdColorNavigation.Descripcion, producto.Descripcion, producto.Stock, producto.Precio, producto.Estado);

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListaProductos.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            string nom = TBBuscar.Text;
            string cat = CBCategoria.Text;
            string talle = CBTalle.Text;
            string color = CBColor.Text;
            CargarProductos(nom, cat, talle, color);
        }

        private void CBCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarTallesPorCategoria();
        }

        private void FiltrarTallesPorCategoria()
        {
            if (CBCategoria.SelectedValue is int categoriaId)
            {
                if (categoriaId == 0) // Si se selecciona "Todos"
                {
                    CBTalle.SelectedValue = 0; // Seleccionar "Todos" en CBTalleBuscar
                }
                var categoria = categoriaRepositorio.BuscarCategoriaPorId(categoriaId);
                if (categoria != null)
                {
                    var tallesFiltrados = talleRepositorio.ListarTallesPorTipo(categoria.TipoTalleId);
                    tallesFiltrados.Insert(0, new Talle { Id = 0, Descripcion = "Todos" }); // Agregar la opción "Todos"
                    CBTalle.DataSource = tallesFiltrados;
                }
            }
        }
    }
}
