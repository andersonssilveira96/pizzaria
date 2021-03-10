using FluentValidation;
using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Usuario
{
    public class CadastrarUsuarioCommandValidator : BaseUsuarioCommandValidator
    {
        public CadastrarUsuarioCommandValidator(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
           
        }
    }
}
