using MediatR;
using Pizzaria.Domain.Response.Cliente;

namespace Pizzaria.Domain.Commands.Cliente
{
    public class AtualizarClienteCommand : BaseClienteCommand, IRequest<AtualizarClienteResponse>
    {
    }
}
