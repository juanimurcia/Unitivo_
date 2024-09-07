using System;
using System.Collections.Generic;

namespace Unitivo.Modelos;

public partial class DetalleFactura
{
    public int Id { get; set; }

    public int Cantidad { get; set; }

    public decimal Precio { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int IdFactura { get; set; }

    public int IdProducto { get; set; }

    public virtual Factura? IdFacturaNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
