using FluentValidation;
using Pizzaria.Domain.Commands.Perfil;
using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Perfil
{
    public class BasePerfilCommandValidator : AbstractValidator<BasePerfilCommand>
    {
        private readonly IPerfilRepository _perfiloRepository;

        public BasePerfilCommandValidator(IPerfilRepository perfilRepository)
        {
            _perfiloRepository = perfilRepository;

            RuleFor(e => e.Id)
               .Must((Id) =>
               {
                   return perfilRepository.VerificarPerfilExistente(Id);
               }).WithMessage("Não existe um perfil com esse Id")
               .When(e => e.Id > 0);

            RuleFor(e => e.Descricao)
              .NotEmpty().WithMessage("Descricao é obrigatório")
              .MinimumLength(3).WithMessage("Descricao possui mínimo de 3 caracteres")
              .MaximumLength(300).WithMessage("Descricao possui máximo de 300 caracteres")
              .Must((perfil, Descricao) =>
              {
                  return !perfilRepository.VerificarPerfilExistente(perfil.Id, Descricao);
              }).WithMessage("Já existe um perfil cadastrado com esse nome");
        }
    }
}
