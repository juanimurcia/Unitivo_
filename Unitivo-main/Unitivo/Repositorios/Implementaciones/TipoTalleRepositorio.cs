using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorio.Interfaces;
using Unitivo.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unitivo.Repositorios.Interfaces;

namespace Unitivo.Repositorios.Implementaciones
{
    public class TipoTalleRepositorio : TipoTalleInterface
    {
        private readonly UnitivoContext? _contexto;

        public TipoTalleRepositorio()
        {
            _contexto = Contexto.dbContexto;
        }

        public bool AgregarTipoTalle(TipoTalle tipoTalle)
        {
            if (BuscarTipoTalle(tipoTalle.Descripcion).Count > 0)
            {
                return false;
            }
            try
            {
                _contexto?.TipoTalles.Add(tipoTalle);
                _contexto?.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TipoTalles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool EliminarTipoTalle(int id)
        {
            TipoTalle? tipoTalle = _contexto?.TipoTalles.Find(id);
            if (tipoTalle == null) return false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public bool ModificarTipoTalle(TipoTalle tipoTalle)
        {
            try
            {
                if (BuscarTipoTalleExacta(tipoTalle.Descripcion).Count > 0)
                {
                    MessageBox.Show("Ya existe un tipo de talle con esa descripcion", "TipoTalles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _contexto?.TipoTalles.Update(tipoTalle);
                int resultado = _contexto?.SaveChanges() ?? 0;
                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TipoTalles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public TipoTalle BuscarTipoTallePorId(int id)
        {
            TipoTalle tipoTalle = _contexto?.TipoTalles.Find(id)!;
            return tipoTalle;
        }

        public List<TipoTalle> BuscarTipoTalle(string nombre)
        {
            List<TipoTalle> tipoTalles = _contexto?.TipoTalles.Where(x => x.Descripcion.Contains(nombre)).ToList()!;
            return tipoTalles;
        }

        public List<TipoTalle> BuscarTipoTalleExacta(string nombre)
        {
            List<TipoTalle> tipoTalles = _contexto?.TipoTalles.Where(x => x.Descripcion == nombre).ToList()!;
            return tipoTalles;
        }

        public List<TipoTalle> ListarTipoTalles()
        {
            List<TipoTalle> tipoTalles = _contexto?.TipoTalles.ToList()!;
            return tipoTalles;
        }

        public bool ReactivarTipoTalle(int id)
        {
            TipoTalle tipoTalle = (from t in _contexto?.TipoTalles
                                   where t.Id == id
                                   select t).First();
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }
    }
}

