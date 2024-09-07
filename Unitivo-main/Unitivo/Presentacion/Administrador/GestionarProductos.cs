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
using Unitivo.Presentacion.SuperAdministrador;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Administrador
{
    public partial class GestionarProductos : Form
    {
        private ProductoRepositorio productoRepositorio = new ProductoRepositorio();
        private CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
        private TalleRepositorio talleRepositorio = new TalleRepositorio();
        private ColorRepositorio colorRepositorio = new ColorRepositorio();
        private Producto productoParaEditar = new Producto();

        public GestionarProductos()
        {
            InitializeComponent();
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarDecimalKeyPress((TextBox)sender, e);
        }
        private void NumInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }
        private void BEliminarProducto_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaProductos.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            if (DataGridViewListaProductos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idEliminar = (int)DataGridViewListaProductos.SelectedRows[0].Cells["ID"].Value;
                    if (productoRepositorio.EliminarProducto(idEliminar))
                    {
                        MessageBox.Show("El producto se eliminó correctamente.", "producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string nom = TBBuscar.Text;
                        string cat = CBCatBuscar.Text;
                        string talle = CBTalleBuscar.Text;
                        string col = CBColorBuscar.Text;
                        CargarProductos(nom, cat, talle, col);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el producto.", "producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            // Aquí puedes agregar el código para eliminar el producto seleccionado.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool CBoxsNoVacios = (CBCategoriaProducto.Text != "" && CBTalleProducto.Text != "" && CBColorProducto.Text != "");
            if (CBoxsNoVacios && productoParaEditar.Id != 0 && TBNombreProducto.Text.Trim() != "" && TBPrecioProducto.Text.Trim() != "" && TBStockAdic.Text.Trim() != "" && TBDescripcionProducto.Text.Trim() != "" && !(TBPrecioProducto.Text.Trim().Contains(".") && TBPrecioProducto.Text.Trim().Split('.')[1].Length > 2))
            {
                productoParaEditar = productoRepositorio.BuscarProducto(productoParaEditar.Id);
                productoParaEditar.Nombre = TBNombreProducto.Text.Trim();
                productoParaEditar.Precio = decimal.Parse(TBPrecioProducto.Text.Trim());
                productoParaEditar.Descripcion = TBDescripcionProducto.Text.Trim();
                productoParaEditar.IdCategoria = (int)CBCategoriaProducto.SelectedValue!;
                productoParaEditar.IdTalle = (int)CBTalleProducto.SelectedValue!;
                productoParaEditar.IdColor = (int)CBColorProducto.SelectedValue!;
                productoParaEditar.Stock += int.Parse(TBStockAdic.Text.Trim());
                int stockAgregar = int.Parse(TBStockAdic.Text);

                if (productoRepositorio.ModificarProducto(productoParaEditar, stockAgregar))
                {
                    productoParaEditar = new Producto();
                    CargarProductos();
                    MessageBox.Show("Se modifico con exito", "exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBStockProducto.Text = "";
                    TBNombreProducto.Text = "";
                    TBPrecioProducto.Text = "";
                    TBStockAdic.Text = "";
                    TBDescripcionProducto.Text = "";
                    CBCategoriaProducto.SelectedValue = -1;
                    CBColorProducto.SelectedValue = -1;
                    CBTalleProducto.SelectedValue = -1;

                }
                else
                {
                    MessageBox.Show("Ocurrio un error al modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarProductos()
        {
            List<Producto> productos = productoRepositorio.ListarProductos();
            DataGridViewListaProductos.Rows.Clear();
            DataGridViewListaProductos.Refresh();
            foreach (Producto producto in productos)
            {
                if (producto.Estado == true)
                {
                    DataGridViewListaProductos.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.IdTalleNavigation.Descripcion, producto.IdColorNavigation.Descripcion, producto.Stock, producto.Precio, producto.Descripcion, producto.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListaProductos.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.IdTalleNavigation.Descripcion, producto.IdColorNavigation.Descripcion, producto.Stock, producto.Precio, producto.Descripcion, producto.Estado);

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListaProductos.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void GestionarProductos_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            cargarTalles();
            cargarColores();
            CargarProductos();
            BReactivar.Visible = false;
            BEliminarProducto.Visible = false;
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            BReactivar.Visible = false;
            BEliminarProducto.Visible = false;
            string nom = TBBuscar.Text;
            string cat = CBCatBuscar.Text;
            string talle = CBTalleBuscar.Text;
            string col = CBColorBuscar.Text;
            CargarProductos(nom, cat, talle, col);

        }

        private void cargarCategorias()
        {
            CBCategoriaProducto.DataSource = categoriaRepositorio.ListarCategoriasActivos();
            CBCategoriaProducto.ValueMember = "Id";
            CBCategoriaProducto.DisplayMember = "Descripcion";
            CBCategoriaProducto.SelectedValue = -1;

            var categorias = categoriaRepositorio.ListarCategoriasActivos();
            categorias.Insert(0, new Categoria { Id = 0, Descripcion = "Todos" }); // Agregar la opción "Todos"
            CBCatBuscar.DataSource = categorias;
            CBCatBuscar.DisplayMember = "Descripcion";
            CBCatBuscar.ValueMember = "Id";


        }

        private void cargarTalles()
        {
            var talles = talleRepositorio.ListarTallesActivos();
            talles.Insert(0, new Talle { Id = 0, Descripcion = "Todos" }); // Agregar la opción "Todos"
            CBTalleBuscar.DataSource = talles;
            CBTalleBuscar.ValueMember = "Id";
            CBTalleBuscar.DisplayMember = "Descripcion";
            CBTalleBuscar.SelectedValue = 0;

            CBTalleProducto.DataSource = talleRepositorio.ListarTallesActivos();
            CBTalleProducto.ValueMember = "Id";
            CBTalleProducto.DisplayMember = "Descripcion";
            CBTalleProducto.SelectedValue = -1;


        }

        private void cargarColores()
        {
            var colores = colorRepositorio.ListarColoresActivos();
            colores.Insert(0, new Modelos.Color { Id = 0, Descripcion = "Todos" }); // Agregar la opción "Todos"
            CBColorBuscar.DataSource = colores;
            CBColorBuscar.DisplayMember = "Descripcion";
            CBColorBuscar.ValueMember = "Id";


            CBColorProducto.DataSource = colorRepositorio.ListarColoresActivos();
            CBColorProducto.ValueMember = "Id";
            CBColorProducto.DisplayMember = "Descripcion";
            CBColorProducto.SelectedValue = -1;
        }

        private void CargarProductos(string nom, string cat, string talle, string col)
        {
            if (cat == "Todos")
            {
                cat = "";
            }
            if (talle == "Todos")
            {
                talle = "";
            }
            if (col == "Todos")
            {
                col = "";
            }
            List<Producto> productos = productoRepositorio.BuscarProductos(nom, cat, talle, col);
            DataGridViewListaProductos.Rows.Clear();
            DataGridViewListaProductos.Refresh();
            foreach (Producto producto in productos)
            {
                if (producto.Estado == true)
                {
                    DataGridViewListaProductos.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.IdTalleNavigation.Descripcion, producto.IdColorNavigation.Descripcion, producto.Stock, producto.Precio, producto.Descripcion, producto.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListaProductos.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.IdTalleNavigation.Descripcion, producto.IdColorNavigation.Descripcion, producto.Stock, producto.Precio, producto.Descripcion, producto.Estado);

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListaProductos.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void DataGridViewListaProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Obtener la fila que fue doble clickeada
                DataGridViewRow filaSeleccionada = DataGridViewListaProductos.Rows[e.RowIndex];
                bool estadoSelect = (bool)filaSeleccionada.Cells["Estado"].Value;
                if (estadoSelect == false)
                {
                    BEliminarProducto.Visible = false;
                    BReactivar.Visible = true;
                }
                else
                {
                    BEliminarProducto.Visible = true;
                    BReactivar.Visible = false;
                }
            }

        }

        private void DataGridViewListaProductos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void BModificarProducto_Click(object sender, EventArgs e)
        {
            TBStockProducto.Text = "";
            TBNombreProducto.Text = "";
            TBPrecioProducto.Text = "";
            TBStockAdic.Text = "";
            TBDescripcionProducto.Text = "";
            CBCategoriaProducto.SelectedValue = -1;
            CBColorProducto.SelectedValue = -1;
            CBTalleProducto.SelectedValue = -1;

            if (DataGridViewListaProductos.SelectedRows.Count > 0)
            {
                var fila = DataGridViewListaProductos.SelectedRows[0];
                int idProducto = (int)DataGridViewListaProductos.SelectedRows[0].Cells["ID"].Value;

                TBNombreProducto.Text = fila.Cells["Producto"].Value.ToString();
                TBPrecioProducto.Text = fila.Cells["Precio"].Value.ToString();
                CBCategoriaProducto.Text = fila.Cells["Categoria"].Value.ToString();
                CBTalleProducto.Text = fila.Cells["Talle"].Value.ToString();
                CBColorProducto.Text = fila.Cells["DGColor"].Value.ToString();
                TBStockProducto.Text = fila.Cells["Stock"].Value.ToString();
                TBDescripcionProducto.Text = fila.Cells["Descripcion"].Value.ToString();
                TBStockAdic.Text = "0";

                productoParaEditar.Id = idProducto;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
        }

        private void BReactivar_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaProductos.SelectedRows.Count > 0)
            {
                // Obtener la fila que fue doble clickeada
                int IdSelect = (int)DataGridViewListaProductos.SelectedRows[0].Cells["ID"].Value; ;
                if (productoRepositorio.reactivarProducto(IdSelect))
                {
                    MessageBox.Show("Se ha reactivado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ya estaba activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                string nom = TBBuscar.Text;
                string cat = CBCatBuscar.Text;
                string talle = CBTalleBuscar.Text;
                string col = CBColorBuscar.Text;
                CargarProductos(nom, cat, talle, col);
            }
        }

        private void TBPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumStr_KeyPress(sender, e);
        }

        private void TBStockAdic_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumInt_KeyPress(sender, e);
        }

        private void CBCatBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCatBuscar.SelectedValue is int categoriaId)
            {
                CBTalleBuscar.Enabled = true;
                if (categoriaId == 0) // Si se selecciona "Todos"
                {
                    CBTalleBuscar.SelectedValue = 0; // Seleccionar "Todos" en CBTalleBuscar
                }
                var categoria = categoriaRepositorio.BuscarCategoriaPorId(categoriaId);
                if (categoria != null)
                {
                    var tallesFiltrados = talleRepositorio.ListarTallesPorTipo(categoria.TipoTalleId);
                    tallesFiltrados.Insert(0, new Talle { Id = 0, Descripcion = "Todos" }); // Agregar la opción "Todos"
                    CBTalleBuscar.DataSource = tallesFiltrados;
                    CBTalleBuscar.SelectedValue = 0;
                }
            }

        }

        private void CBCategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCategoriaProducto.SelectedValue is int categoriaId)
            {
                var categoria = categoriaRepositorio.BuscarCategoriaPorId(categoriaId);
                if (categoria != null)
                {
                    CBTalleProducto.Enabled = true;
                    var tallesFiltrados = talleRepositorio.ListarTallesPorTipo(categoria.TipoTalleId);
                    CBTalleProducto.DataSource = tallesFiltrados;
                }
            }

        }

        private void CBTalleProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBCategoriaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void TBBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void TBNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void GroupBoxBuscarProducto_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TBNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBoxDatosCliente_Enter(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TBNombreProducto_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TBPrecioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
