using MediatR;
using Pizzaria.Domain.Response.Cliente;

namespace Pizzaria.Domain.Commands.Cliente
{
    public class DeletarClienteCommand : IRequest<DeletarClienteResponse>
    {
        public int Id { get; set; }
    }
}
