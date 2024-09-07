using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Presentacion.Vendedor;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Administrador
{
    public partial class ListarVentasAdmin : Form
    {
        FacturaRepositorio facturaRepositorio = new FacturaRepositorio();
        DetalleFacturaRepositorio detalleFacturaRepositorio = new DetalleFacturaRepositorio();
        public ListarVentasAdmin()
        {
            InitializeComponent();
            CargarVentas();
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void BVerDetalle_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaVentas.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
            else
            {
                int idSeleccionado = Convert.ToInt32(DataGridViewListaVentas.SelectedRows[0].Cells["ID"].Value);

                DetalleVenta detalleVentaForm = new DetalleVenta(detalleFacturaRepositorio.ListarDetalleFacturas(idSeleccionado));
                detalleVentaForm.Show();
            }
        }

        private void ListarVentasAdmin_Load(object sender, EventArgs e)
        {
        }

        private void CargarVentas()
        {
            List<Factura> facturas = facturaRepositorio.ListarFacturas();
            DataGridViewListaVentas.Rows.Clear();
            DataGridViewListaVentas.Refresh();

            foreach (Factura factura in facturas)
            {
                string nomCliente = factura.IdClienteNavigation.Apellido + ", " + factura.IdClienteNavigation.Nombre;
                string nomVendedor = factura.IdUsuarioNavigation.IdEmpleadoNavigation.Apellido + ", " + factura.IdUsuarioNavigation.IdEmpleadoNavigation.Nombre;
                DataGridViewListaVentas.Rows.Add(factura.Id, factura.FechaCreacion, nomCliente, nomVendedor, factura.Precio);
            }
        }

        private void CargarVentas(DateTime desde, DateTime hasta, string nomUsuario)
        {
            List<Factura> facturas = facturaRepositorio.VentasPorFechas(desde, hasta, nomUsuario);
            DataGridViewListaVentas.Rows.Clear();
            DataGridViewListaVentas.Refresh();

            foreach (Factura factura in facturas)
            {
                string nomCliente = factura.IdClienteNavigation.Apellido + ", " + factura.IdClienteNavigation.Nombre;
                string nomVendedor = factura.IdUsuarioNavigation.IdEmpleadoNavigation.Apellido + ", " + factura.IdUsuarioNavigation.IdEmpleadoNavigation.Nombre;
                DataGridViewListaVentas.Rows.Add(factura.Id, factura.FechaCreacion, nomCliente, nomVendedor, factura.Precio);
            }
        }

        private void DataGridViewListaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BBuscarVenta_Click(object sender, EventArgs e)
        {
            DateTime fecha = System.DateTime.Now;
            if (DateTimeDesde.Value > DateTimeHasta.Value || DateTimeDesde.Value > fecha || DateTimeHasta.Value > fecha)
            {
                MessageBox.Show("Fecha incorrecta.", "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CargarVentas(DateTimeDesde.Value, DateTimeHasta.Value.AddDays(1), TBBuscar.Text);
            }
        }
    }
}
