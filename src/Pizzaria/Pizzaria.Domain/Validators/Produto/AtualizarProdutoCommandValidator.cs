using FluentValidation;
using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Produto
{
    public class AtualizarProdutoCommandValidator : BaseProdutoCommandValidator
    {
        public AtualizarProdutoCommandValidator(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository) : base(produtoRepository)
        {
            RuleFor(e => e.CategoriaId)
               .Must((categoriaId) =>
               {
                   return categoriaRepository.VerificarCategoriaExistente(categoriaId);
               }).WithMessage("Não existe uma categoria com esse Id")
               .When(e => e.Id > 0);
        }
    }
}
