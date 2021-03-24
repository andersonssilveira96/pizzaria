using MediatR;
using Pizzaria.Domain.Response.Produto;

namespace Pizzaria.Domain.Commands.Produto
{
    public class CadastrarProdutoCommand : BaseProdutoCommand, IRequest<CadastrarProdutoResponse>
    {
        public int UsuarioInclusaoId { get; set; }
    }
}
