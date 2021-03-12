using MediatR;
using Pizzaria.Core.Domain.Response;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Queries.Perfil;
using Pizzaria.Domain.Response.Perfil;
using Pizzaria.Domain.Response.Permissao;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Queries
{
    public class PerfilQueryHandler : 
        IRequestHandler<ListarPerfilQuery, IEnumerable<BasePerfilResponse>>,
        IRequestHandler<ObterPerfilQuery, PerfilCompletoResponse>        
    {
        private readonly IPerfilRepository _perfilRepository;
        public PerfilQueryHandler(IPerfilRepository perfilRepository)
        {
            _perfilRepository = perfilRepository;
        }
        public Task<IEnumerable<BasePerfilResponse>> Handle(ListarPerfilQuery query, CancellationToken cancellationToken)
        {
            return Task.FromResult(_perfilRepository.ObterTodos().Select(ToListResponse));
        }
        public Task<PerfilCompletoResponse> Handle(ObterPerfilQuery query, CancellationToken cancellationToken)
        {
            var perfil = _perfilRepository.ObterPorId(query.Id);

            if (perfil != null)
                return Task.FromResult(ToListResponseCompleto(perfil));
            else
                return Task.FromResult(new PerfilCompletoResponse() { Sucesso = false });
        }

        private BasePerfilResponse ToListResponse(Perfil perfil)
        {
            return new BasePerfilResponse()
            {
                Id = perfil.Id,
                Descricao = perfil.Descricao                
            };
        }

        private PerfilCompletoResponse ToListResponseCompleto(Perfil perfil)
        {
            return new PerfilCompletoResponse()
            {
                Id = perfil.Id,
                Descricao = perfil.Descricao,
                Permissao = perfil.PerfilPermissao.Select(ObterPermissao)
            };
        }

        private static PermissaoResponse ObterPermissao(PerfilPermissao perfilPermissao)
        {
            return new PermissaoResponse()
            {
                Abreviacao = perfilPermissao.Permissao.Abreviacao,
                Descricao = perfilPermissao.Permissao.Descricao
            };
        }
    }
}
