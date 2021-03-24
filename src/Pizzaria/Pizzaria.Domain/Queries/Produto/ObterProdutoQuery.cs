using MediatR;
using Pizzaria.Domain.Response.Produto;

namespace Pizzaria.Domain.Queries.Produto
{
    public class ObterProdutoQuery : IRequest<ProdutoCompletoResponse>
    {
        public int Id { get; set; }
    }
}
