using FluentValidation.Results;
using MediatR;
using Pizzaria.Domain.Commands.Cliente;
using Pizzaria.Domain.Factories.Clientes;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Response.Cliente;
using Pizzaria.Domain.Validators.Cliente;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Commands.Cliente
{
    public class ClienteCommandHandler : IRequestHandler<CadastrarClienteCommand, CadastrarClienteResponse>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEnderecoRepository _enderecoRepository;
        public ClienteCommandHandler(IClienteRepository clienteRepository, IEnderecoRepository enderecoRepository)
        {
            _clienteRepository = clienteRepository;
            _enderecoRepository = enderecoRepository;
        }

        public Task<CadastrarClienteResponse> Handle(CadastrarClienteCommand command, CancellationToken cancellationToken)
        {
            CadastrarClienteCommandValidator validator = new CadastrarClienteCommandValidator(_clienteRepository, _enderecoRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                var cliente = ClienteFactory.Criar(command);

                _clienteRepository.Adicionar(cliente);
                _clienteRepository.Salvar();

                return Task.FromResult(new CadastrarClienteResponse() { Sucesso = true, Mensagem = new List<string>() { "Cliente cadastrado com sucesso" } });
            }

            return Task.FromResult(new CadastrarClienteResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }
    }
}
