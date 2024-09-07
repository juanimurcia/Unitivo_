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

namespace Unitivo.Repositorios.Implementaciones
{
    public class TalleRepositorio : TalleInterface
    {
        private readonly UnitivoContext? _contexto;

        public TalleRepositorio()
        {
            _contexto = Contexto.dbContexto;
            _contexto?.TipoTalles.Load();
        }

        public bool AgregarTalle(Talle x)
        {
            if (BuscarTalleExacto(x.Descripcion).Count > 0)
            {
                return false;
            }
            try
            {
                x.Estado = true;
                _contexto?.Talles.Add(x);
                _contexto?.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Talles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool EliminarTalle(int id)
        {
            Talle? Talle = _contexto?.Talles.Find(id);
            if (Talle == null) return false;
            Talle.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }
        public bool ModificarTalle(Talle talle)
        {

            try
            {
                if (BuscarTalleExacto(talle.Descripcion).Count > 0)
                {
                    MessageBox.Show("Ya existe un Talle con esa descripcion", "Talles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _contexto?.Talles.Update(talle);
                int resultado = _contexto?.SaveChanges() ?? 0;
                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Talles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public Talle BuscarTallePorId(int id)
        {
            Talle Talle = _contexto?.Talles.Find(id)!;
            return Talle;
        }

        public List<Talle> BuscarTalle(string nombre)
        {
            List<Talle> Talles = _contexto?.Talles.Where(x => x.Descripcion.Contains(nombre)).ToList()!;
            return Talles;
        }
        public List<Talle> BuscarTalleExacto(string nombre)
        {
            List<Talle> Talles = _contexto?.Talles.Where(x => x.Descripcion == nombre).ToList()!;
            return Talles;
        }

        public List<Talle> ListarTalles()
        {
            List<Talle> talles = _contexto?.Talles.ToList()!;
            return talles;
        }
        public List<Talle> ListarTallesActivos()
        {
            List<Talle> talles = _contexto?.Talles.Where(x => x.Estado == true).ToList()!;
            return talles;
        }

        public bool reactivarTalle(int id)
        {
            Talle tal = (from t in _contexto?.Talles
                             where t.Id == id
                             select t).First();
            tal.Estado = true;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public List<Talle> ListarTallesPorTipo(int tipoTalleId)
        {
            return _contexto.Talles.Where(t => t.TipoTalleId == tipoTalleId && t.Estado).ToList();
        }

    }
}

