using System;
using System.Collections.Generic;

namespace Unitivo.Modelos;

public partial class Perfile
{
    public int Id { get; set; }

    public string DescripcionPerfil { get; set; } = "";

    public bool EstadoPerfil { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
