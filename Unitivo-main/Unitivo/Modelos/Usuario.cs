using System;
using System.Collections.Generic;

namespace Unitivo.Modelos;

public partial class Usuario
{
    public int Id { get; set; }

    public string? NombreUsuario { get; set; }

    public string Password { get; set; } = null!;

    public bool Estado { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int IdPerfil { get; set; }

    public int IdEmpleado { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    public virtual Perfile IdPerfilNavigation { get; set; } = null!;
}
