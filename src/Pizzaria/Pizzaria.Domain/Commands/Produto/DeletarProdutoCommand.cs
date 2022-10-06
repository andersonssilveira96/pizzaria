using MediatR;
using Pizzaria.Domain.Response.Produto;

namespace Pizzaria.Domain.Commands.Produto
{
    public class DeletarProdutoCommand : IRequest<DeletarProdutoResponse>
    {
        public int Id { get; set; }
    }
}
