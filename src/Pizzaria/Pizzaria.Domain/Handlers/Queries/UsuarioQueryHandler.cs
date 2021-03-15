using AutoMapper;
using MediatR;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Queries.Usuario;
using Pizzaria.Domain.Response.Perfil;
using Pizzaria.Domain.Response.Permissao;
using Pizzaria.Domain.Response.Usuario;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Queries
{
    public class UsuarioQueryHandler : 
        IRequestHandler<ListarUsuariosQuery, IEnumerable<BaseUsuarioResponse>>,
        IRequestHandler<ObterUsuarioQuery, UsuarioCompletoResponse>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        public UsuarioQueryHandler(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }
        public Task<IEnumerable<BaseUsuarioResponse>> Handle(ListarUsuariosQuery query, CancellationToken cancellationToken)
        {
            var retorno = _usuarioRepository.ObterTodos();
            return Task.FromResult(_mapper.Map<IEnumerable<BaseUsuarioResponse>>(retorno));
        }

        public Task<UsuarioCompletoResponse> Handle(ObterUsuarioQuery query, CancellationToken cancellationToken)
        {
            var usuario = _usuarioRepository.ObterPorId(query.Id);

            if (usuario != null)
                return Task.FromResult(_mapper.Map<UsuarioCompletoResponse>(usuario));
            else
                return Task.FromResult(new UsuarioCompletoResponse() { Sucesso = false });
        }       
    }
}
