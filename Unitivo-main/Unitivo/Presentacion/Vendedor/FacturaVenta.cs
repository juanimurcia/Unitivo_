using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Modelos;
using Unitivo.Repositorios.Implementaciones;
using System.Drawing.Printing;
using Unitivo.Formularios.Vendedor;

namespace Unitivo.Presentacion.Vendedor
{
    public partial class FacturaVenta : Form
    {
        FacturaRepositorio facturaRepositorio = new FacturaRepositorio();
        DetalleFacturaRepositorio dFacturaRepositorio = new DetalleFacturaRepositorio();
        Factura factura;
        AñadirVentas ventaform;
        public FacturaVenta(Factura Pfactura)
        {
            InitializeComponent();
            factura = Pfactura;
            CargarFactura();

        }

        public FacturaVenta(Factura Pfactura, AñadirVentas pform)
        {
            InitializeComponent();
            factura = Pfactura;
            CargarFactura();
            ventaform = pform;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarFactura()
        {
            string nomVendedor = factura.IdUsuarioNavigation.IdEmpleadoNavigation.Apellido + ", " + factura.IdUsuarioNavigation.IdEmpleadoNavigation.Nombre;
            string nomCliente = factura.IdClienteNavigation.Apellido + ", " + factura.IdClienteNavigation.Nombre;
            string dniVendedor = factura.IdUsuarioNavigation.IdEmpleadoNavigation.Dni + "";
            string dniCliente = factura.IdClienteNavigation.Dni + "";
            lvendedor.Text = nomVendedor;
            lcliente.Text = nomCliente;
            ldniVendedor.Text = dniVendedor;
            ldniCliente.Text = dniCliente;
            nFactura.Text = factura.Id.ToString();
            lfecha.Text = factura.FechaCreacion.ToString();
            ltotal.Text = "$ " + factura.Precio;

            CargarDetalle();
        }

        private void CargarDetalle()
        {
            List<DetalleFactura> detallesFactura = dFacturaRepositorio.ListarDetalleFacturas(factura.Id);
            dgvListaVentas.Rows.Clear();
            dgvListaVentas.Refresh();

            foreach (DetalleFactura dfactura in detallesFactura)
            {
                dgvListaVentas.Rows.Add(dfactura.Id, dfactura.IdProductoNavigation.Nombre, dfactura.IdProductoNavigation.Precio, dfactura.Cantidad, dfactura.IdProductoNavigation.IdTalleNavigation.Descripcion, dfactura.IdProductoNavigation.IdColorNavigation.Descripcion, dfactura.Precio);
            }
        }

        private void BImprimir_Click(object sender, EventArgs e)
        {
            BImprimir.Visible = false;
            // Mostrar el diálogo de impresión
            using (PrintDialog printDialog = new PrintDialog())
            {
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // Crear un objeto PrintDocument
                    using (PrintDocument printDocument = new PrintDocument())
                    {
                        // Configurar la impresora seleccionada
                        printDocument.PrinterSettings = printDialog.PrinterSettings;

                        // Asociar el evento PrintPage para dibujar el contenido del formulario en la página
                        printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

                        // Iniciar la impresión
                        printDocument.Print();
                    }
                }
            }
            if (ventaform != null)
            {
                ventaform.Close();
            }

            Close();

        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Obtener el formulario como una imagen
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

            // Dibujar la imagen en la página de impresión
            e.Graphics.DrawImage(bitmap, new PointF(0, 0));
        }
    }
}
