using MediatR;
using Pizzaria.Domain.Response.Produto;
using System.Collections.Generic;

namespace Pizzaria.Domain.Queries.Produto
{
    public class ListarProdutoQuery : IRequest<IEnumerable<BaseProdutoResponse>>
    {
    }
}
