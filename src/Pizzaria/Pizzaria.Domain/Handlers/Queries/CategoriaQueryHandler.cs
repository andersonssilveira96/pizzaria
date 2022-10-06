using AutoMapper;
using MediatR;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Queries.Categoria;
using Pizzaria.Domain.Response.Categoria;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Queries
{
    public class CategoriaQueryHandler :
             IRequestHandler<ListarCategoriaQuery, IEnumerable<BaseCategoriaResponse>>,
             IRequestHandler<ObterCategoriaQuery, CategoriaCompletoResponse>
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;
        public CategoriaQueryHandler(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }

        public Task<IEnumerable<BaseCategoriaResponse>> Handle(ListarCategoriaQuery query, CancellationToken cancellationToken)
        {
            var retorno = _categoriaRepository.ObterTodos();
            return Task.FromResult(_mapper.Map<IEnumerable<BaseCategoriaResponse>>(retorno));
        }
        public Task<CategoriaCompletoResponse> Handle(ObterCategoriaQuery query, CancellationToken cancellationToken)
        {
            var categoria = _categoriaRepository.ObterPorId(query.Id);

            if (categoria != null)
                return Task.FromResult(_mapper.Map<CategoriaCompletoResponse>(categoria));
            else
                return Task.FromResult(new CategoriaCompletoResponse() { Sucesso = false, Mensagem = new List<string>() { "Categoria não encontrada" } });
        }               
    }
}
