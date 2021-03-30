using MediatR;
using Pizzaria.Domain.Response.StatusPedido;
using System.Collections.Generic;

namespace Pizzaria.Domain.Queries.StatusPedido
{
    public class ListarStatusPedidoQuery : IRequest<IEnumerable<StatusPedidoResponse>>
    {
    }
}
