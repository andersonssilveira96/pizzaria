using MediatR;
using Pizzaria.Domain.Commands.Produto;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Response.Produto;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Commands.Produto
{
    public class ProdutoCommandHandler :
            IRequestHandler<CadastrarProdutoCommand, CadastrarProdutoResponse>,
            IRequestHandler<AtualizarProdutoCommand, AtualizarProdutoResponse>,
            IRequestHandler<DeletarProdutoCommand, DeletarProdutoResponse>
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoCommandHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public Task<CadastrarProdutoResponse> Handle(CadastrarProdutoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<AtualizarProdutoResponse> Handle(AtualizarProdutoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<DeletarProdutoResponse> Handle(DeletarProdutoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
