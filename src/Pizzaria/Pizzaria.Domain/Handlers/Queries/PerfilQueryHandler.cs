using MediatR;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Queries.Perfil;
using Pizzaria.Domain.Response.Perfil;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Queries
{
    public class PerfilQueryHandler : IRequestHandler<ListarPerfilQuery, IEnumerable<BasePerfilResponse>>
    {
        private readonly IPerfilRepository _perfilRepository;
        public PerfilQueryHandler(IPerfilRepository perfilRepository)
        {
            _perfilRepository = perfilRepository;
        }
        public Task<IEnumerable<BasePerfilResponse>> Handle(ListarPerfilQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_perfilRepository.ObterTodos().Select(ToListResponse));
        }

        private BasePerfilResponse ToListResponse(Perfil perfil)
        {
            return new BasePerfilResponse()
            {
                Id = perfil.Id,
                Descricao = perfil.Descricao                
            };
        }
    }
}
