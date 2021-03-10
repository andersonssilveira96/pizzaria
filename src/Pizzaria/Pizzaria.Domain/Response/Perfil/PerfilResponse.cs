using Pizzaria.Domain.Response.Permissao;
using System.Collections.Generic;

namespace Pizzaria.Domain.Response.Perfil
{
    public class PerfilResponse : BasePerfilResponse
    {   
        public IEnumerable<PermissaoResponse> Permissao { get; set; }
    }
}
