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

namespace Unitivo.Presentacion.Vendedor
{
    public partial class ListarVentas : Form
    {
        FacturaRepositorio facturaRepositorio = new FacturaRepositorio();
        DetalleFacturaRepositorio detalleFacturaRepositorio = new DetalleFacturaRepositorio();
        public ListarVentas()
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
            List<Factura> facturas = facturaRepositorio.VentasPorFechasClientes(desde, hasta, nomUsuario);
            DataGridViewListaVentas.Rows.Clear();
            DataGridViewListaVentas.Refresh();

            foreach (Factura factura in facturas)
            {
                string nomCliente = factura.IdClienteNavigation.Apellido + ", " + factura.IdClienteNavigation.Nombre;
                string nomVendedor = factura.IdUsuarioNavigation.IdEmpleadoNavigation.Apellido + ", " + factura.IdUsuarioNavigation.IdEmpleadoNavigation.Nombre;
                DataGridViewListaVentas.Rows.Add(factura.Id, factura.FechaCreacion, nomCliente, nomVendedor, factura.Precio);
            }
        }


        private void ListarVentas_Load(object sender, EventArgs e)
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

        private void BImprimir_Click(object sender, EventArgs e)
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

                FacturaVenta facturaImprimir = new FacturaVenta(facturaRepositorio.buscarFactura(idSeleccionado));
                facturaImprimir.Show();
            }
        }
    }
}
