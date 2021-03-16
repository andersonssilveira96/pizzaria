using MediatR;
using Pizzaria.Domain.Commands.Cliente;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Response.Cliente;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Commands.Cliente
{
    public class ClienteCommandHandler : IRequestHandler<CadastrarClienteCommand, CadastrarClienteResponse>
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteCommandHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Task<CadastrarClienteResponse> Handle(CadastrarClienteCommand command, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
