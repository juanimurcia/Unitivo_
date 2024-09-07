using System.Windows.Forms;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Presentacion.Vendedor;
using Unitivo.Repositorios.Implementaciones;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Unitivo.Formularios.Vendedor
{
    public partial class AñadirVentas : Form
    {
        private Cliente clienteCompra = new Cliente();
        private Producto productoCompra = new Producto();
        private Usuario vendedor = new Usuario();
        private UsuariosRepositorio usuariosRepositorio = new UsuariosRepositorio();
        private ProductoRepositorio productoRepositorio = new ProductoRepositorio();
        private FacturaRepositorio facturaRepositorio = new FacturaRepositorio();
        private DetalleFacturaRepositorio detalleFacturaRepositorio = new DetalleFacturaRepositorio();
        public AñadirVentas(Usuario pVendedor)
        {
            InitializeComponent();
            vendedor = pVendedor;
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {
            clienteCompra = new Cliente();
            TBDniCliVenta.Clear();
            TBNombreCliVenta.Clear();
            TBTelCliVenta.Clear();
            TBNombreCliVenta.Clear();
            // El TextBox está vacío, así que debes mostrar el formulario BuscarCliente como un diálogo modal.
            BuscarCliente buscarClienteForm = new BuscarCliente(this);
            DialogResult result = buscarClienteForm.ShowDialog();

            // Aquí puedes manejar el resultado si es necesario.
            if (result == DialogResult.OK)
            {
                // Realiza alguna acción después de seleccionar un cliente en el formulario BuscarCliente.
            }

        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            TBCantidad.Enabled = false;
            productoCompra = new Producto();
            TBProductoVenta.Clear();
            TBStock.Clear();
            TBPrecio.Clear();
            TBTalle.Clear();
            TBCantidad.Clear();
            TBColor.Clear();
            // El TextBox está vacío, así que debes mostrar el formulario BuscarProducto como un diálogo modal.
            BuscarProducto buscarProductoForm = new BuscarProducto(this);
            DialogResult result = buscarProductoForm.ShowDialog();

            // Aquí puedes manejar el resultado si es necesario.
            if (result == DialogResult.OK)
            {
                // Realiza alguna acción después de seleccionar un producto en el formulario BuscarProducto.
            }

        }

        private void BAñadir_Click(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está vacío.
            if (string.IsNullOrEmpty(TBDniCliVenta.Text) ||
                string.IsNullOrEmpty(TBNombreCliVenta.Text) ||
                string.IsNullOrEmpty(TBApellidoCliVenta.Text) ||
                string.IsNullOrEmpty(TBTelCliVenta.Text) ||
                string.IsNullOrEmpty(TBProductoVenta.Text) ||
                string.IsNullOrEmpty(TBPrecio.Text) ||
                string.IsNullOrEmpty(TBStock.Text) ||
                string.IsNullOrEmpty(TBTalle.Text) ||
                string.IsNullOrEmpty(TBColor.Text) ||
                string.IsNullOrEmpty(TBCantidad.Text) || (int.TryParse(TBCantidad.Text, out int cantidad) && cantidad <= 0))
            {
                // Al menos uno de los campos está vacío, mostrar un mensaje de error.
                MessageBox.Show("Por favor, complete todos los campos correctamente antes de añadir la venta.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.Parse(TBCantidad.Text) > productoCompra.Stock)
                {
                    MessageBox.Show("No hay suficiente stock de ese producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    int result = (int)MessageBox.Show("¿Seguro que desea Guardar el producto a la venta?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    DialogResult ask = (DialogResult)result;

                    if (ask == DialogResult.Yes)
                    {
                        // Código a ejecutar si la respuesta es "Sí"
                        AgregarFilaProd();
                        TBTotal.Text = actualizarTotalPrecio().ToString();

                        TBProductoVenta.Clear();
                        TBCantidad.Clear();
                        TBStock.Clear();
                        TBPrecio.Clear();
                        TBTalle.Clear();
                        TBColor.Clear();
                        TBCantidad.Enabled = false;
                        productoCompra = new Producto();
                        // Todos los campos están llenos, puedes realizar la acción de agregar el producto.
                        // Agregar código aquí para realizar la acción deseada, por ejemplo, agregar el producto a una lista o base de datos.

                        // Después de agregar el producto, mostrar un mensaje de éxito.
                        MessageBox.Show("Producto añadido con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }

            }
        }


        private void BEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvListaVentas.SelectedRows.Count > 0)
            {
                var fila = dgvListaVentas.SelectedRows[0];
                dgvListaVentas.Rows.Remove(fila);
                TBTotal.Text = actualizarTotalPrecio().ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para remover un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            // Aquí puedes agregar el código para eliminar el producto seleccionado.
        }

        private void BModificarProducto_Click(object sender, EventArgs e)
        {

            if (dgvListaVentas.SelectedRows.Count > 0)
            {
                var fila = dgvListaVentas.SelectedRows[0];
                int idProducto = (int)dgvListaVentas.SelectedRows[0].Cells["Codigo"].Value;
                Producto productoEditar = productoRepositorio.BuscarProducto(idProducto);
                UtilizarProducto(productoEditar);
                dgvListaVentas.Rows.Remove(fila);
                TBTotal.Text = actualizarTotalPrecio().ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            // Aquí puedes agregar el código para eliminar el producto seleccionado.
        }


        private void BConfirmar_Click(object sender, EventArgs e)
        {
            /*
            // Crear una instancia del formulario ModificarPerfiles
            FacturaVenta facturaVentaForm = new FacturaVenta();

            // Mostrar el formulario como un cuadro de diálogo modal
            DialogResult result = facturaVentaForm.ShowDialog();

            // Aquí puedes realizar acciones después de que se cierre el formulario ModificarPerfiles
            if (result == DialogResult.OK)
            {
                // Por ejemplo, actualizar la lista de perfiles o realizar otras acciones necesarias
                // después de modificar el perfil.
            }
            */





            if (dgvListaVentas.Rows.Count <= 0 || CommonFunctions.ValidarCamposNoVacios(this))
            {
                MessageBox.Show("Complete los datos necesarios para realizar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (GuardarVenta(dgvListaVentas))
                {
                    MessageBox.Show("Venta completada exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FacturaVenta facturaVentaForm = new FacturaVenta(facturaRepositorio.UltimaVenta(), this);
                    facturaVentaForm.Show();

                }
                else
                {
                    MessageBox.Show("Ocurrio un error al realizar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private bool GuardarVenta(DataGridView dgvVentas)
        {
            Factura factura = new Factura();
            factura.IdUsuario = vendedor.Id;
            factura.IdCliente = clienteCompra.Id;
            decimal totalPrecio = decimal.Parse(TBTotal.Text);
            factura.Precio = totalPrecio;

            if (facturaRepositorio.AgregarFactura(factura))
            {
                int idVenta = facturaRepositorio.idUltimaVenta();
                if (GuardarDetalleVenta(idVenta, dgvListaVentas))
                {
                    return true;
                }
            }
            return false;
        }

        private bool GuardarDetalleVenta(int idVenta, DataGridView dgvVentas)
        {
            DetalleFactura dFactura = new DetalleFactura();
            dFactura.IdFactura = idVenta;

            foreach (DataGridViewRow fila in dgvVentas.Rows)
            {
                dFactura.Id = 0;
                dFactura.Cantidad = int.Parse(fila.Cells["Cantidad"].Value.ToString()!);
                dFactura.Precio = decimal.Parse(fila.Cells["Precio"].Value.ToString()!);
                dFactura.IdProducto = int.Parse(fila.Cells["Codigo"].Value.ToString()!);
                if (!detalleFacturaRepositorio.AgregarDetalleFactura(dFactura))
                {
                    return false;
                }
                productoRepositorio.ReducirStockProducto(dFactura.IdProducto, dFactura.Cantidad);
            }
            return true;
        }



        public void UtilizarCliente(Cliente cli)
        {
            clienteCompra = cli;
            TBDniCliVenta.Text = clienteCompra.Dni.ToString();
            TBNombreCliVenta.Text = clienteCompra.Nombre;
            TBApellidoCliVenta.Text = clienteCompra.Apellido;
            TBTelCliVenta.Text = clienteCompra.Telefono;
        }

        public void UtilizarProducto(Producto prod)
        {
            productoCompra = prod;
            TBCantidad.Enabled = true;
            TBProductoVenta.Text = productoCompra.Id.ToString();
            TBPrecio.Text = productoCompra.Precio.ToString();
            TBStock.Text = productoCompra.Stock.ToString();
            TBTalle.Text = productoCompra.IdTalleNavigation.Descripcion;
            TBColor.Text = productoCompra.IdColorNavigation.Descripcion;
        }

        private void AñadirVentas_Load(object sender, EventArgs e)
        {
            Fecha.Value = DateTime.Now;
            TBVendedor.Text = vendedor.IdEmpleadoNavigation.Apellido + ", " + vendedor.IdEmpleadoNavigation.Nombre;
            TBNroFactura.Text = (facturaRepositorio.idUltimaVenta() + 1) + "";
        }

        private int existeProdDataGrid()
        {
            foreach (DataGridViewRow fila in dgvListaVentas.Rows)
            {
                if (int.Parse(fila.Cells["Codigo"].Value.ToString()) == int.Parse(productoCompra.Id.ToString()))
                {
                    return (int)fila.Cells["Codigo"].RowIndex;
                }
            }
            return -1;
        }

        private void AgregarFilaProd()
        {
            int indexfilaProd = existeProdDataGrid();

            if (indexfilaProd > -1)
            {
                int antCant = int.Parse(dgvListaVentas.Rows[indexfilaProd].Cells["Cantidad"].Value.ToString()!);
                int CantAgregada = int.Parse(TBCantidad.Text);

                if ((antCant + CantAgregada) <= productoCompra.Stock)
                {
                    dgvListaVentas.Rows[indexfilaProd].Cells["Cantidad"].Value = antCant + CantAgregada;

                    decimal antPrecio = (decimal)dgvListaVentas.Rows[indexfilaProd].Cells["Precio"].Value;
                    decimal PrecioAgregado = productoCompra.Precio * decimal.Parse(TBCantidad.Text);

                    dgvListaVentas.Rows[indexfilaProd].Cells["Precio"].Value = antPrecio + PrecioAgregado;
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock de ese producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                CrearFilaProd();
            }
        }

        private void CrearFilaProd()
        {
            int numRow = dgvListaVentas.Rows.Add();
            dgvListaVentas.Rows[numRow].Cells["Codigo"].Value = productoCompra.Id;
            dgvListaVentas.Rows[numRow].Cells["Descripcion"].Value = productoCompra.Nombre;
            dgvListaVentas.Rows[numRow].Cells["Precio"].Value = decimal.Parse(TBCantidad.Text) * productoCompra.Precio;
            dgvListaVentas.Rows[numRow].Cells["Cantidad"].Value = TBCantidad.Text.Trim();
            dgvListaVentas.Rows[numRow].Cells["Talle"].Value = TBTalle.Text.Trim();
            dgvListaVentas.Rows[numRow].Cells["DGColor"].Value = TBColor.Text.Trim();

        }

        private decimal actualizarTotalPrecio()
        {
            decimal precio = 0;
            foreach (DataGridViewRow fila in dgvListaVentas.Rows)
            {
                precio = decimal.Parse(fila.Cells["Precio"].Value.ToString()!) + precio;
            }
            return precio;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
