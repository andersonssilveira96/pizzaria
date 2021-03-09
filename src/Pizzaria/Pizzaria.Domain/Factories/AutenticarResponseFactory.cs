using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Response.Autenticacao;
using Pizzaria.Domain.Response.Perfil;
using Pizzaria.Domain.Response.Permissao;
using System.Linq;

namespace Pizzaria.Domain.Factories
{
    public static class AutenticarResponseFactory
    {
        public static AutenticarResponse Criar(Usuario usuario, string token)
        {
            return new AutenticarResponse()
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Email = usuario.Email.Valor,
                Token = token,
                Sucesso = true,
                Perfil = new PerfilResponse()
                {
                    PerfilId = usuario.PerfilId,
                    Descricao = usuario.Perfil.Descricao,
                    Permissao = usuario.Perfil.PerfilPermissao.Select(ObterPermissao)
                }
            };
        }

        private static PermissaoResponse ObterPermissao(PerfilPermissao perfilPermissao)
        {
            return new PermissaoResponse() { 
                Abreviacao = perfilPermissao.Permissao.Abreviacao,
                Descricao = perfilPermissao.Permissao.Descricao
            };
        }
    }
}
