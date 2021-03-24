using AutoMapper;
using MediatR;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Queries.Produto;
using Pizzaria.Domain.Response.Produto;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Queries
{
    public class ProdutoQueryHandler :
             IRequestHandler<ListarProdutoQuery, IEnumerable<BaseProdutoResponse>>,
             IRequestHandler<ObterProdutoQuery, ProdutoCompletoResponse>
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;
        public ProdutoQueryHandler(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }
        public Task<IEnumerable<BaseProdutoResponse>> Handle(ListarProdutoQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProdutoCompletoResponse> Handle(ObterProdutoQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
