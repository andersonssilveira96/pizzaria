using Pizzaria.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaria.Domain.Factories.PermissaoPerfil
{
    public static class PerfilPermissaoFactory
    {
        public static IEnumerable<PerfilPermissao> Criar(int perfilId, List<int> permissaoId)
        {
            return permissaoId.Select(x => new PerfilPermissao(perfilId, x));          
        }
    }
}
