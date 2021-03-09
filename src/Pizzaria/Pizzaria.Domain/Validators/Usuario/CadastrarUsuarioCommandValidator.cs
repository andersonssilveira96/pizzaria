using FluentValidation;
using Pizzaria.Domain.Commands.Usuario;

namespace Pizzaria.Domain.Validators.Usuario
{
    public class CadastrarUsuarioCommandValidator : AbstractValidator<CadastrarUsuarioCommand>
    {
        public CadastrarUsuarioCommandValidator()
        {
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


            RuleFor(e => e.Senha)
               .NotEmpty().WithMessage("Senha é obrigatória")
               .MinimumLength(3).WithMessage("Senha possui mínimo de 3 caracteres")
               .MaximumLength(300).WithMessage("Senha possui máximo de 300 caracteres");

            RuleFor(e => e.Email)
                .NotEmpty().WithMessage("Email é obrigatório")
                .MinimumLength(3).WithMessage("Email possui mínimo de 3 caracteres")
                .MaximumLength(300).WithMessage("Email possui máximo de 300 caracteres")
                .EmailAddress().WithMessage("Email está em um formato inválido");
        }
    }
}
