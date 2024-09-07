using System;
using System.Collections.Generic;

namespace Unitivo.Modelos
{
    public partial class Talle
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        // Foreign key
        public int TipoTalleId { get; set; }

        // Navigation property
        public virtual TipoTalle TipoTalleIdNavigation { get; set; } = null!;

        // Productos relacionados
        public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}

