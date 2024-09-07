using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;

namespace Unitivo.Sessions
{
    public static class LocalStorage
    {
        public static List<Producto>? productos { get; set; } 

        public static List<Talle>? talles { get; set; }

        public static List<Categoria>? categorias { get; set; }

        //clientes
        public static List<Cliente>? clientes { get; set; } 

        //usuarios
        public static List<Usuario>? usuarios { get; set; }

        //empleados
        public static List<Empleado>? empleados { get; set; }
    }
}
