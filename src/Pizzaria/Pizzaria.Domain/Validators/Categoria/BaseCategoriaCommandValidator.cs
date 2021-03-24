using FluentValidation;
using Pizzaria.Domain.Commands.Categoria;
using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Categoria
{
    public class BaseCategoriaCommandValidator : AbstractValidator<BaseCategoriaCommand>
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public BaseCategoriaCommandValidator(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;

            RuleFor(e => e.Id)
               .Must((Id) =>
               {
                   return _categoriaRepository.VerificarCategoriaExistente(Id);
               }).WithMessage("Não existe uma categoria com esse Id")
               .When(e => e.Id > 0);

            RuleFor(e => e.Descricao)
              .NotEmpty().WithMessage("Descricao é obrigatório")
              .MinimumLength(3).WithMessage("Descricao possui mínimo de 3 caracteres")
              .MaximumLength(300).WithMessage("Descricao possui máximo de 300 caracteres")
              .Must((perfil, Descricao) =>
              {
                  return !_categoriaRepository.VerificarCategoriaExistente(perfil.Id, Descricao);
              }).WithMessage("Já existe uma categoria cadastrada com esse nome");
        }
    }
}
