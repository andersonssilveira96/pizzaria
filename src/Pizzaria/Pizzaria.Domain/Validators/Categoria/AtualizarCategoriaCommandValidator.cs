using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Categoria
{
    public class AtualizarCategoriaCommandValidator : BaseCategoriaCommandValidator
    {
        public AtualizarCategoriaCommandValidator(ICategoriaRepository categoriaRepository) : base(categoriaRepository)
        {
        }
    }
}
