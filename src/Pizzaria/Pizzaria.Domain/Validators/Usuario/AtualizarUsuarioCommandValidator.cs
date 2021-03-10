using FluentValidation;
using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Usuario
{
    public class AtualizarUsuarioCommandValidator : BaseUsuarioCommandValidator
    {
        public AtualizarUsuarioCommandValidator(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            RuleFor(e => e.Id)             
             .Must((Id) => {
                 return usuarioRepository.VerificarUsuarioExistente(Id);
             }).WithMessage("Não existe um usuário com esse Id");
        }
    }
}
