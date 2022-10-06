using FluentValidation;
using Pizzaria.Domain.Commands.Endereco;
using Pizzaria.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Validators.Endereco
{
    public class BaseEnderecoCommandValidator : AbstractValidator<BaseEnderecoCommand>
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public BaseEnderecoCommandValidator(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;           

            RuleFor(e => e.Bairro)
              .NotEmpty().WithMessage("Bairro é obrigatório")
              .MinimumLength(3).WithMessage("Bairro possui mínimo de 3 caracteres")
              .MaximumLength(300).WithMessage("Bairro possui máximo de 300 caracteres");

            RuleFor(e => e.Cidade)
              .NotEmpty().WithMessage("Cidade é obrigatório")
              .MinimumLength(3).WithMessage("Cidade possui mínimo de 3 caracteres")
              .MaximumLength(300).WithMessage("Cidade possui máximo de 300 caracteres");

            RuleFor(e => e.CEP)
              .NotEmpty().WithMessage("CEP é obrigatório")
              .MinimumLength(8).WithMessage("CEP possui mínimo de 8 caracteres")
              .MaximumLength(8).WithMessage("CEP possui máximo de 8 caracteres");

            RuleFor(e => e.Numero)
              .GreaterThan(0).WithMessage("Numero é obrigatório");

            RuleFor(e => e.Rua)
                .NotEmpty().WithMessage("Rua é obrigatório")
                .MinimumLength(3).WithMessage("Rua possui mínimo de 3 caracteres")
                .MaximumLength(300).WithMessage("Rua possui máximo de 300 caracteres");

            RuleFor(e => e.Estado)
               .NotEmpty().WithMessage("Estado é obrigatório")
               .MinimumLength(2).WithMessage("Estado possui mínimo de 2 caracteres")
               .MaximumLength(2).WithMessage("Estado possui máximo de 2 caracteres");

        }
    }
}
