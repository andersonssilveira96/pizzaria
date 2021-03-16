using MediatR;
using Pizzaria.Domain.Response.Cliente;

namespace Pizzaria.Domain.Queries.Cliente
{
    public class ObterClienteQuery : BaseClienteQuery, IRequest<ClienteCompletoResponse>
    {
    }
}
