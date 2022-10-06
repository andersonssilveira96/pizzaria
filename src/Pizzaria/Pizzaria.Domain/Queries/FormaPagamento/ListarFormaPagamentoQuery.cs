using MediatR;
using Pizzaria.Domain.Response.FormaPagamento;
using System.Collections.Generic;

namespace Pizzaria.Domain.Queries.FormaPagamento
{
    public class ListarFormaPagamentoQuery : IRequest<IEnumerable<FormaPagamentoResponse>>
    {
    }
}
