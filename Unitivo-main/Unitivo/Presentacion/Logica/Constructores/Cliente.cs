using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitivo.Presentacion.Logica.Constructores
{
    public class ClienteConstructor
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public int Dni { get; set; }

        public string Telefono { get; set; } = null!;

        public string? Direccion { get; set; }

        public string Correo { get; set; } = null!;

        public bool Estado { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public int? UsuarioCreacion { get; set; }

        public int? UsuarioModificacion { get; set; }




        public ClienteConstructor(string nombre, string apellido, int dni, string telefono, string direccion, string correo)
            {
                Nombre = nombre;
                Apellido = apellido;
                Dni = dni;
                Telefono = telefono;
                Direccion = direccion;
                Correo = correo;
            }
    }

}
