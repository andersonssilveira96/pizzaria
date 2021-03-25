using FluentValidation;
using Pizzaria.Domain.Commands.Produto;
using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Produto
{
    public class BaseProdutoCommandValidator : AbstractValidator<BaseProdutoCommand>
    {
        private readonly IProdutoRepository _produtoRepository;
        public BaseProdutoCommandValidator(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;

            RuleFor(e => e.Id)
               .Must((Id) =>
               {
                   return _produtoRepository.VerificarProdutoExistente(Id);
               }).WithMessage("Não existe um produto com esse Id")
               .When(e => e.Id > 0);

            RuleFor(e => e.Descricao)
              .NotEmpty().WithMessage("Descricao é obrigatório")
              .MinimumLength(3).WithMessage("Descricao possui mínimo de 3 caracteres")
              .MaximumLength(300).WithMessage("Descricao possui máximo de 300 caracteres")
              .Must((produto, Descricao) =>
              {
                  return !_produtoRepository.VerificarProdutoExistente(produto.Id, Descricao);
              }).WithMessage("Já existe um produto cadastrada com esse nome");


            RuleFor(e => e.Valor)
                .NotNull()
                .WithMessage("Valor é obrigatório");

        }
    }
}
