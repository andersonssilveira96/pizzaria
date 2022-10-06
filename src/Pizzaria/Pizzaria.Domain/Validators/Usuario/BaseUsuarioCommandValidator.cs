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
    public class BaseUsuarioCommandValidator : AbstractValidator<BaseUsuarioCommand>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public BaseUsuarioCommandValidator(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;

            RuleFor(e => e.Id)
               .Must((Id) =>
               {
                   return usuarioRepository.VerificarUsuarioExistente(Id);
               }).WithMessage("Não existe um usuário com esse Id")
               .When(e => e.Id > 0);

            RuleFor(e => e.Nome)
              .NotEmpty().WithMessage("Nome é obrigatório")
              .MinimumLength(3).WithMessage("Nome possui mínimo de 3 caracteres")
              .MaximumLength(300).WithMessage("Nome possui máximo de 300 caracteres");

            RuleFor(e => e.Sobrenome)
              .NotEmpty().WithMessage("Sobrenome é obrigatório")
              .MinimumLength(3).WithMessage("Sobrenome possui mínimo de 3 caracteres")
              .MaximumLength(300).WithMessage("Sobrenome possui máximo de 300 caracteres");

            RuleFor(e => e.Telefone)
                .GreaterThan(0).WithMessage("Telefone é obrigatório");          

            RuleFor(e => e.DDD)
              .GreaterThan(0).WithMessage("DDD é obrigatório");

            RuleFor(e => e.PerfilId)
                .GreaterThan(0).WithMessage("Perfil é obrigatório");

            RuleFor(e => e.Senha)
               .NotEmpty().WithMessage("Senha é obrigatória")
               .MinimumLength(3).WithMessage("Senha possui mínimo de 3 caracteres")
               .MaximumLength(300).WithMessage("Senha possui máximo de 300 caracteres");

            RuleFor(e => e.Email)
                .NotEmpty().WithMessage("Email é obrigatório")
                .MinimumLength(3).WithMessage("Email possui mínimo de 3 caracteres")
                .MaximumLength(300).WithMessage("Email possui máximo de 300 caracteres")
                .EmailAddress().WithMessage("Email está em um formato inválido")
                .Must((usuario, email) => {
                    return !_usuarioRepository.VerificarEmailExistente(usuario.Id, email);
                }).WithMessage("Já contém um usuário com esse email cadastrado");
        }
    }
}
