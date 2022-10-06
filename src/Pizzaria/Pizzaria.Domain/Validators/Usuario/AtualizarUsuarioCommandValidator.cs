using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Usuario
{
    public class AtualizarUsuarioCommandValidator : BaseUsuarioCommandValidator
    {
        public AtualizarUsuarioCommandValidator(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        { 
        }
    }
}
