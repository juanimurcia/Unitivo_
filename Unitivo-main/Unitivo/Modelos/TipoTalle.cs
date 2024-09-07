using System;
using System.Collections.Generic;

namespace Unitivo.Modelos;

public partial class TipoTalle
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Talle> Talles { get; set; } = new List<Talle>();
    public virtual ICollection<Categoria> Categorias { get; set; } = new List<Categoria>();
}
