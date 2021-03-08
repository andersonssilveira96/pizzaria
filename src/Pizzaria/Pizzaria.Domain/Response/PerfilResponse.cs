using System.Collections.Generic;

namespace Pizzaria.Domain.Response
{
    public class PerfilResponse
    {
        public int PerfilId { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<PermissaoResponse> Permissao { get; set; }
    }
}
