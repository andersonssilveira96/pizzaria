using FluentValidation;
using Pizzaria.Domain.Commands.Categoria;
using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Categoria
{
    public class DeletarCategoriaCommandValidator : AbstractValidator<BaseCategoriaCommand>
    {
        public DeletarCategoriaCommandValidator(ICategoriaRepository categoriaRepository, IProdutoRepository produtoRepository)
        {
            RuleFor(e => e.Id)
               .Must((Id) =>
               {
                   return categoriaRepository.VerificarCategoriaExistente(Id);
               }).WithMessage("Não existe um perfil com esse Id")
               .When(e => e.Id > 0);

            RuleFor(e => e.Id)
              .Must((Id) =>
              {
                  return !produtoRepository.VerificarProdutoComCategoria(Id);
              }).WithMessage("Existem produtos com essa categoria, não é possível deletar")
              .When(e => e.Id > 0);
        }
    }
}
