using FluentValidation.Results;
using MediatR;
using Pizzaria.Core.Domain.ValueObjects;
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
    public class ClienteCommandHandler : 
         IRequestHandler<CadastrarClienteCommand, CadastrarClienteResponse>,
         IRequestHandler<AtualizarClienteCommand, AtualizarClienteResponse>,
         IRequestHandler<DeletarClienteCommand, DeletarClienteResponse>
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

        public Task<AtualizarClienteResponse> Handle(AtualizarClienteCommand command, CancellationToken cancellationToken)
        {
            AtualizarClienteCommandValidator validator = new AtualizarClienteCommandValidator(_clienteRepository, _enderecoRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                var cliente = _clienteRepository.ObterPorId(command.Id);

                cliente.Endereco.Alterar(command.Endereco.Rua, command.Endereco.Numero, command.Endereco.Complemento, command.Endereco.Bairro, command.Endereco.Cidade, command.Endereco.Estado, command.Endereco.CEP);
                cliente.Alterar(new CPF(command.CPF), new Email(command.Email), command.Nome, command.DDD, command.Telefone);

                _clienteRepository.Atualizar(cliente);
                _clienteRepository.Salvar();

                return Task.FromResult(new AtualizarClienteResponse() { Sucesso = true, Mensagem = new List<string>() { "Cliente atualizado com sucesso" } });
            }

            return Task.FromResult(new AtualizarClienteResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }

        public Task<DeletarClienteResponse> Handle(DeletarClienteCommand command, CancellationToken cancellationToken)
        {
            DeletarClienteCommandValidator validator = new DeletarClienteCommandValidator(_clienteRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                var cliente = _clienteRepository.ObterPorId(command.Id);
                
                _clienteRepository.Remover(cliente.Id);                
                _enderecoRepository.Remover(cliente.Endereco.Id);

                _clienteRepository.Salvar();

                return Task.FromResult(new DeletarClienteResponse() { Sucesso = true, Mensagem = new List<string>() { "Cliente deletado com sucesso" } });
            }

            return Task.FromResult(new DeletarClienteResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }
    }
}
