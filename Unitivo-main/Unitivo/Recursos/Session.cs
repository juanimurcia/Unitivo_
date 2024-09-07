using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;

namespace Unitivo.Sessions
{
    public static class Session
    {
        // almacenar los datos de la sesion
        public static int idUsuario { get; set; }
        public static string nombreUsuario { get; set; } = null!;
        public static string apellidoUsuario { get; set; } = null!;
        public static string correoUsuario { get; set; } = null!;
        public static Usuario usuario { get; set; } = null!;
    }
}
