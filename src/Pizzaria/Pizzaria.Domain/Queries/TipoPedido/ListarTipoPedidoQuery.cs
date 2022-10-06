using MediatR;
using Pizzaria.Domain.Response.TipoPedido;
using System.Collections.Generic;

namespace Pizzaria.Domain.Queries.TipoPedido
{
    public class ListarTipoPedidoQuery : IRequest<IEnumerable<TipoPedidoResponse>>
    {
    }
}
