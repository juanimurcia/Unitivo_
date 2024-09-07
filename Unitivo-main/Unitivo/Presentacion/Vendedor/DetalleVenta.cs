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
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Vendedor
{
    public partial class DetalleVenta : Form
    {
        List<DetalleFactura> detallesFacturas;
        public DetalleVenta(List<DetalleFactura> detalles)
        {
            InitializeComponent();
            detallesFacturas = detalles;
            CargarDetalles();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarDetalles()
        {
            dgvListaVentas.Rows.Clear();
            dgvListaVentas.Refresh();

            foreach (DetalleFactura dfactura in detallesFacturas)
            {
                dgvListaVentas.Rows.Add(dfactura.IdProducto, dfactura.IdProductoNavigation.Nombre , dfactura.Precio, dfactura.Cantidad, dfactura.IdProductoNavigation.IdTalleNavigation.Descripcion, dfactura.IdProductoNavigation.IdColorNavigation.Descripcion, dfactura.IdProductoNavigation.IdCategoriaNavigation.Descripcion);
            }
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
