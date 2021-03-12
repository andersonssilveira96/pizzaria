using FluentValidation;
using Pizzaria.Domain.Commands.Perfil;
using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Perfil
{
    public class DeletarPerfilCommandValidator : AbstractValidator<BasePerfilCommand>
    {
        public DeletarPerfilCommandValidator(IPerfilRepository perfilRepository) 
        {
            RuleFor(e => e.Id)
               .Must((Id) =>
               {
                   return perfilRepository.VerificarPerfilExistente(Id);
               }).WithMessage("Não existe um perfil com esse Id")
               .When(e => e.Id > 0);
        }
    }
}
