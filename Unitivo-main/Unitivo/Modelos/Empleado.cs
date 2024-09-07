using System;
using System.Collections.Generic;

namespace Unitivo.Modelos;

public partial class Empleado
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Dni { get; set; }

    public string Telefono { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public bool Estado { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime Edad { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
