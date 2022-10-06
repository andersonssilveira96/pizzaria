using FluentValidation;
using Pizzaria.Domain.Commands.Perfil;
using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Perfil
{
    public class DeletarPerfilCommandValidator : AbstractValidator<BasePerfilCommand>
    {
        public DeletarPerfilCommandValidator(IPerfilRepository perfilRepository, IUsuarioRepository usuarioRepository) 
        {
            RuleFor(e => e.Id)
               .Must((Id) =>
               {
                   return perfilRepository.VerificarPerfilExistente(Id);
               }).WithMessage("Não existe um perfil com esse Id")
               .When(e => e.Id > 0);

            RuleFor(e => e.Id)
              .Must((Id) =>
              {
                  return !usuarioRepository.VerificarUsuarioExistenteComPerfil(Id);
              }).WithMessage("Existem usuários com esse perfil, não é possível deletar")
              .When(e => e.Id > 0);
        }
    }
}
