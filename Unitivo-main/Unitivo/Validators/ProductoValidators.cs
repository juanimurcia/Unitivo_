using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Unitivo.Modelos;
using Unitivo.Presentacion.Vendedor;
using Unitivo.Repositorio.Interfaces;
using Unitivo.Repositorios.Implementaciones;
using Unitivo.Repositorios.Interfaces;

namespace Unitivo.Validators
{
    public class ProductoValidator : AbstractValidator<Producto>
    {

        private ProductoRepositorio productoRepositorio = new ProductoRepositorio();
        private CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
        private TalleRepositorio talleRepositorio = new TalleRepositorio();
        
        public ProductoValidator()
        {
            //validar Nombre

            RuleFor(x => x)
                .NotEmpty().WithMessage("El campo Nombre es obligatorio.")
                .Must(ExisteProducto).WithMessage("Ya existe el producto.")
                ;

            //validar categoria
            RuleFor(x => x.IdCategoria)
                .NotEmpty().WithMessage("El campo Categoria es obligatorio")
                .Must(ExisteCategoria).WithMessage("No existe una categoria con ese id.");
                ;
            //validar talle
            RuleFor(x => x.IdTalle)
                .NotEmpty().WithMessage("El campo Talle es obligatorio")
                .Must(ExisteTalle).WithMessage("No existe un talle con ese id")
                ;
            //validar stock
            RuleFor(x => x.Stock)
                .NotEmpty().WithMessage("El campo Stock es obligatorio")
                .Must(x => x > 0).WithMessage("El campo Stock debe ser mayor a 0")
                ;
            //validar precio
            RuleFor(x => x.Precio)
                .NotEmpty().WithMessage("El campo Telefono es obligatorio")
                .Must(x => x > 0).WithMessage("El campo Precio debe ser mayor a 0")
                ;
        }


        private bool ExisteProducto(Producto producto){

            var prods = productoRepositorio!.BuscarProductoNombreExacto(producto.Nombre);
            if (prods.Count < 1)
            {
                return true;
            }
            else
            {
                foreach (Producto prod in prods)
                {
                    if ((prod.Id != producto.Id) && (producto.IdTalle == prod.IdTalle) && (producto.IdCategoria == prod.IdCategoria) && (producto.IdColor == prod.IdColor))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        private bool ExisteCategoria(int id)
        {
            return (categoriaRepositorio!.BuscarCategoriaPorId(id) != null);
        }
        private bool ExisteTalle(int id){
            return (talleRepositorio!.BuscarTallePorId(id) != null);
        }
    }
}
