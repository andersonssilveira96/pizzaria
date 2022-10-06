using FluentValidation;
using Pizzaria.Domain.Commands.Autenticacao;

namespace Pizzaria.Domain.Validators.Autenticacao
{
    public class AutenticarCommandValidator : AbstractValidator<AutenticarCommand>
    {
        public AutenticarCommandValidator()
        {
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
