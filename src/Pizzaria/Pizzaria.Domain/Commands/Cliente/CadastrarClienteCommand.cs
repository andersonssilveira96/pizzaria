using MediatR;
using Pizzaria.Domain.Response.Cliente;

namespace Pizzaria.Domain.Commands.Cliente
{
    public class CadastrarClienteCommand : BaseClienteCommand, IRequest<CadastrarClienteResponse>
    {
    }
}
