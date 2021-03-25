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
        public Task<IEnumerable<BaseProdutoResponse>> Handle(ListarProdutoQuery query, CancellationToken cancellationToken)
        {
            var retorno = _produtoRepository.ObterTodos();
            return Task.FromResult(_mapper.Map<IEnumerable<BaseProdutoResponse>>(retorno));
        }

        public Task<ProdutoCompletoResponse> Handle(ObterProdutoQuery query, CancellationToken cancellationToken)
        {
            var produto = _produtoRepository.ObterPorId(query.Id);

            if (produto != null)
                return Task.FromResult(_mapper.Map<ProdutoCompletoResponse>(produto));
            else
                return Task.FromResult(new ProdutoCompletoResponse() { Sucesso = false, Mensagem = new List<string>() { "Produto não encontrado" } });
        }
    }
}
