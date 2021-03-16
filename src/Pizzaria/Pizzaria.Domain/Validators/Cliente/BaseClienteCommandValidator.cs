using FluentValidation;
using Pizzaria.Domain.Commands.Cliente;
using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Cliente
{
    public class BaseClienteCommandValidator : AbstractValidator<BaseClienteCommand>
    {
        private readonly IClienteRepository _clienteRepository;
        public BaseClienteCommandValidator(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;

            RuleFor(e => e.Id)
               .Must((Id) =>
               {
                   return _clienteRepository.VerificarClienteExistente(Id);
               }).WithMessage("Não existe um usuário com esse Id")
               .When(e => e.Id > 0);

            RuleFor(e => e.Nome)
              .NotEmpty().WithMessage("Nome é obrigatório")
              .MinimumLength(3).WithMessage("Nome possui mínimo de 3 caracteres")
              .MaximumLength(300).WithMessage("Nome possui máximo de 300 caracteres");

            RuleFor(e => e.CPF)
              .NotEmpty().WithMessage("CPF é obrigatório")
              .MinimumLength(3).WithMessage("CPF possui mínimo de 3 caracteres")
              .MaximumLength(300).WithMessage("CPF possui máximo de 300 caracteres");

            RuleFor(e => e.Telefone)
                .GreaterThan(0).WithMessage("Telefone é obrigatório");

            RuleFor(e => e.DDD)
              .GreaterThan(0).WithMessage("DDD é obrigatório");
          
            RuleFor(e => e.Email)
                .NotEmpty().WithMessage("Email é obrigatório")
                .MinimumLength(3).WithMessage("Email possui mínimo de 3 caracteres")
                .MaximumLength(300).WithMessage("Email possui máximo de 300 caracteres")
                .EmailAddress().WithMessage("Email está em um formato inválido")
                .Must((cliente, email) => {
                    return !_clienteRepository.VerificarEmailExistente(cliente.Id, email);
                }).WithMessage("Já contém um cliente com esse email cadastrado");
        }
    }
}
