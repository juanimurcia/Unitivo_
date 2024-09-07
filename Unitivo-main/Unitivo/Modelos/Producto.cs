using System;
using System.Collections.Generic;

namespace Unitivo.Modelos;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public bool Estado { get; set; }

    public string Descripcion { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int IdCategoria { get; set; }

    public int IdTalle { get; set; }

    public int IdColor { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;

    public virtual Talle IdTalleNavigation { get; set; } = null!;

    public virtual Color IdColorNavigation { get; set; } = null!;
}
