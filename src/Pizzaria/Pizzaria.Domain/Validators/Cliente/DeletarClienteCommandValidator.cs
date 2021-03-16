using FluentValidation;
using Pizzaria.Domain.Commands.Cliente;
using Pizzaria.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Validators.Cliente
{
    public class DeletarClienteCommandValidator : AbstractValidator<DeletarClienteCommand>
    {
        private readonly IClienteRepository _clienteRepository;
        public DeletarClienteCommandValidator(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;         

            RuleFor(e => e.Id)
               .Must((Id) =>
               {
                   return _clienteRepository.VerificarClienteExistente(Id);
               }).WithMessage("Não existe um usuário com esse Id")
               .When(e => e.Id > 0);           
        }
    }
}
