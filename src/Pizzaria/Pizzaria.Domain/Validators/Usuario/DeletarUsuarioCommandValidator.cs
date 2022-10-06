using FluentValidation;
using Pizzaria.Domain.Commands.Usuario;
using Pizzaria.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Validators.Usuario
{
    public class DeletarUsuarioCommandValidator : AbstractValidator<DeletarUsuarioCommand>
    {       
        public DeletarUsuarioCommandValidator(IUsuarioRepository usuarioRepository)
        {
            RuleFor(e => e.Id)
             .Must((Id) => {
                 return usuarioRepository.VerificarUsuarioExistente(Id);
             }).WithMessage("Não existe um usuário com esse Id");
        }
    }
}
