using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorio.Interfaces;

namespace Unitivo.Repositorios.Implementaciones
{
    public class PerfilRepositorio : PerfilInterface
    {
        private readonly UnitivoContext? _contexto;

        public PerfilRepositorio()
        {
            _contexto = Contexto.dbContexto;
        }

        public bool AgregarPerfil(Perfile x)
        {
            try
            {
                x.EstadoPerfil = true;
                if (BuscarPerfilExacto(x.DescripcionPerfil).Count > 0)
                {
                    MessageBox.Show("El perfil ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _contexto?.Perfiles.Add(x);
                _contexto?.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool EliminarPerfil(int id)
        {
            Perfile? perfil = _contexto?.Perfiles.Find(id);
            if (perfil == null) return false;
            perfil.EstadoPerfil = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            MessageBox.Show("Se desactivo correctamente", "Exito");
            return resultado > 0;
        }

        public bool ReactivarPerfil(int id)
        {
            Perfile? perfil = _contexto?.Perfiles.Find(id);
            if (perfil == null) return false;
            perfil.EstadoPerfil = true;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public bool ModificarPerfil(Perfile perfile)
        {
            if (BuscarPerfilExacto(perfile.DescripcionPerfil).Count > 0)
            {
                MessageBox.Show("Ya existe un perfil con esa descripcion", "Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                Perfile modif = (from perfil in _contexto?.Perfiles
                                 where perfile.Id == perfil.Id
                                 select perfil).First();


                modif.Id = perfile.Id;
                modif.DescripcionPerfil = perfile.DescripcionPerfil;
                modif.EstadoPerfil = perfile.EstadoPerfil;
                int resultado = _contexto?.SaveChanges() ?? 0;
                MessageBox.Show("Se cambio correctamente", "Exito");
                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public Perfile BuscarPerfilPorId(int id)
        {
            return _contexto?.Perfiles.Find(id)!;
        }

        public List<Perfile> BuscarPerfil(string nombre)
        {
            return _contexto?.Perfiles.Where(x => x.DescripcionPerfil.Contains(nombre)).ToList()!;
        }

        public List<Perfile> BuscarPerfilExacto(string nombre)
        {
            return _contexto?.Perfiles.Where(x => x.DescripcionPerfil.Equals(nombre)).ToList()!;
        }

        public List<Perfile> ListarPerfiles()
        {
            return _contexto?.Perfiles.ToList()!;
        }
        public List<Perfile> ListarPerfilesActivos()
        {
            return _contexto?.Perfiles.Where(x => x.EstadoPerfil == true).ToList()!;
        }
        public List<Perfile> ListarPerfilesDesactivos()
        {
            return _contexto?.Perfiles.Where(x => x.EstadoPerfil == false).ToList()!;
        }
    }
}