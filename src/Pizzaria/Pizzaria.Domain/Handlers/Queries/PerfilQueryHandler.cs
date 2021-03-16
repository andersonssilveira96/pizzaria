using AutoMapper;
using MediatR;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Queries.Perfil;
using Pizzaria.Domain.Response.Perfil;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Queries
{
    public class PerfilQueryHandler : 
        IRequestHandler<ListarPerfilQuery, IEnumerable<BasePerfilResponse>>,
        IRequestHandler<ObterPerfilQuery, PerfilCompletoResponse>        
    {
        private readonly IPerfilRepository _perfilRepository;
        private readonly IMapper _mapper;
        public PerfilQueryHandler(IPerfilRepository perfilRepository, IMapper mapper)
        {
            _perfilRepository = perfilRepository;
            _mapper = mapper;
        }
        public Task<IEnumerable<BasePerfilResponse>> Handle(ListarPerfilQuery query, CancellationToken cancellationToken)
        {
            var retorno = _perfilRepository.ObterTodos();
            return Task.FromResult(_mapper.Map<IEnumerable<BasePerfilResponse>>(retorno));
        }
        public Task<PerfilCompletoResponse> Handle(ObterPerfilQuery query, CancellationToken cancellationToken)
        {
            var perfil = _perfilRepository.ObterPorId(query.Id);

            if (perfil != null)
                return Task.FromResult(_mapper.Map<PerfilCompletoResponse>(perfil));
            else
                return Task.FromResult(new PerfilCompletoResponse() { Sucesso = false, Mensagem = new List<string>() { "Perfil não encontrado" } });
        }       
    }
}
