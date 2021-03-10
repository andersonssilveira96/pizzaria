using MediatR;
using Pizzaria.Core.Domain.Response;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Queries.Usuario;
using Pizzaria.Domain.Response.Perfil;
using Pizzaria.Domain.Response.Permissao;
using Pizzaria.Domain.Response.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Queries
{
    public class UsuarioQueryHandler : 
        IRequestHandler<ListarUsuariosQuery, IEnumerable<BaseUsuarioResponse>>,
        IRequestHandler<ObterUsuarioQuery, BaseUsuarioResponse>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioQueryHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public Task<IEnumerable<BaseUsuarioResponse>> Handle(ListarUsuariosQuery query, CancellationToken cancellationToken)
        {
            return Task.FromResult(_usuarioRepository.ObterTodos().Select(ToListResponse));
        }

        public Task<BaseUsuarioResponse> Handle(ObterUsuarioQuery query, CancellationToken cancellationToken)
        {
            var usuario = _usuarioRepository.ObterPorId(query.Id);

            if (usuario != null)
                return Task.FromResult(ToResponse(usuario));
            else
                return Task.FromResult(new BaseUsuarioResponse() { Sucesso = false, Mensagem = new List<string>() { "Usuario não existe" } });
        }

        private BaseUsuarioResponse ToResponse(Usuario usuario) 
        {
            return new BaseUsuarioResponse()
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                SobreNome = usuario.Sobrenome,
                DDD = usuario.DDD,
                Telefone = usuario.Telefone,
                Email = usuario.Email.Valor,
                Perfil = new PerfilResponse()
                {
                    PerfilId = usuario.PerfilId,
                    Descricao = usuario.Perfil.Descricao,
                    Permissao = usuario.Perfil.PerfilPermissao.Select(ObterPermissao)
                }
            };
        }

        private BaseUsuarioResponse ToListResponse(Usuario usuario)
        {
            return new BaseUsuarioResponse()
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                SobreNome = usuario.Sobrenome,
                DDD = usuario.DDD,
                Telefone = usuario.Telefone,
                Email = usuario.Email.Valor,
                Perfil = new PerfilResponse()
                {
                    PerfilId = usuario.PerfilId,
                    Descricao = usuario.Perfil.Descricao
                }
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
