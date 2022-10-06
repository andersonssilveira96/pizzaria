using MediatR;
using Pizzaria.Domain.Response.Produto;

namespace Pizzaria.Domain.Commands.Produto
{
    public class AtualizarProdutoCommand : BaseProdutoCommand, IRequest<AtualizarProdutoResponse>
    {
    }
}
