using FluentValidation;
using Pizzaria.Domain.Commands.Produto;
using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Produto
{
    public class DeletarProdutoCommandValidator : AbstractValidator<DeletarProdutoCommand>
    {
        public DeletarProdutoCommandValidator(IProdutoRepository produtoRepository)
        {
            RuleFor(e => e.Id)
               .Must((Id) =>
               {
                   return produtoRepository.VerificarProdutoExistente(Id);
               }).WithMessage("Não existe um produto com esse Id")
               .When(e => e.Id > 0);            
        }
    }
}
