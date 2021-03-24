using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Categoria
{
    public class CadastrarCategoriaCommandValidator : BaseCategoriaCommandValidator
    {
        public CadastrarCategoriaCommandValidator(ICategoriaRepository categoriaRepository) : base(categoriaRepository)
        {
        }
    }
}
