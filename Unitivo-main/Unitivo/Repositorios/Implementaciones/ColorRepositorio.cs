using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorio.Interfaces;
using Unitivo.Sessions;
using Unitivo.Presentacion.Logica.Constructores;
using Unitivo.Validators;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Unitivo.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using Color = Unitivo.Modelos.Color;

namespace Unitivo.Repositorios.Implementaciones
{
    public class ColorRepositorio
    {
        private readonly UnitivoContext? _contexto;

        public ColorRepositorio()
        {
            _contexto = Contexto.dbContexto;
        }

        public bool AgregarColor(Color x)
        {
            if (BuscarColorExacto(x.Descripcion).Count > 0)
            {
                return false;
            }
            try
            {
                x.Estado = true;
                _contexto?.Colores.Add(x);
                _contexto?.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Colores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool EliminarColor(int id)
        {
            Color? Color = _contexto?.Colores.Find(id);
            if (Color == null) return false;
            Color.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }
        public bool ModificarColor(Color color)
        {

            try
            {
                if (BuscarColorExacto(color.Descripcion).Count > 0)
                {
                    MessageBox.Show("Ya existe un Color con esa descripcion", "Colores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _contexto?.Colores.Update(color);
                int resultado = _contexto?.SaveChanges() ?? 0;
                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Colores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public Color BuscarColorPorId(int id)
        {
            Color Color = _contexto?.Colores.Find(id)!;
            return Color;
        }

        public List<Color> BuscarColor(string nombre)
        {
            List<Color> Colores = _contexto?.Colores.Where(x => x.Descripcion.Contains(nombre)).ToList()!;
            return Colores;
        }
        public List<Color> BuscarColorExacto(string nombre)
        {
            List<Color> Colores = _contexto?.Colores.Where(x => x.Descripcion == nombre).ToList()!;
            return Colores;
        }

        public List<Color> ListarColores()
        {
            List<Color> colores = _contexto?.Colores.ToList()!;
            return colores;
        }
        public List<Color> ListarColoresActivos()
        {
            List<Color> colores = _contexto?.Colores.Where(x => x.Estado == true).ToList()!;
            return colores;
        }

        public bool reactivarColor(int id)
        {
            Color tal = (from t in _contexto?.Colores
                             where t.Id == id
                             select t).First();
            tal.Estado = true;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

    }
}

