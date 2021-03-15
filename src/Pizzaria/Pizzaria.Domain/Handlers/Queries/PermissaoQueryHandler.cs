using AutoMapper;
using MediatR;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Queries.Permissao;
using Pizzaria.Domain.Response.Permissao;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Queries
{
    public class PermissaoQueryHandler : IRequestHandler<ListarPermissaoQuery, IEnumerable<PermissaoResponse>>
    {        
        private readonly IPermissaoRepository _permissaoRepository;
        private readonly IMapper _mapper;
        public PermissaoQueryHandler(IPermissaoRepository permissaoRepository, IMapper mapper)
        {
            _permissaoRepository = permissaoRepository;
            _mapper = mapper;
        }
        public Task<IEnumerable<PermissaoResponse>> Handle(ListarPermissaoQuery request, CancellationToken cancellationToken)
        {
            var retorno = _permissaoRepository.ObterTodos();
            return Task.FromResult(_mapper.Map<IEnumerable<PermissaoResponse>>(retorno));
        }
    }
}
