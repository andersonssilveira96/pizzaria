using MediatR;
using Pizzaria.Domain.Response.Cliente;
using System.Collections.Generic;

namespace Pizzaria.Domain.Queries.Cliente
{
    public class ListarClienteQuery : BaseClienteQuery, IRequest<IEnumerable<BaseClienteResponse>>
    {
    }
}
