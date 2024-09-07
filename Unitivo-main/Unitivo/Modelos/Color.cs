using System;
using System.Collections.Generic;

namespace Unitivo.Modelos
{
    public partial class Color
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        // Productos relacionados
        public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}

