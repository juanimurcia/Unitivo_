using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica.Constructores;

namespace Unitivo.Repositorio.Interfaces
{
    public interface CategoriaInterface
    {
        public bool AgregarCategoria(Categoria Categoria);
        public bool EliminarCategoria(int id);
        public bool ModificarCategoria(Categoria Categoria);
        public Categoria BuscarCategoriaPorId(int id);

        public List<Categoria> BuscarCategoria(string nombre);
        public List<Categoria> ListarCategorias();
        public List<Categoria> ListarCategoriasActivos();
    }
}