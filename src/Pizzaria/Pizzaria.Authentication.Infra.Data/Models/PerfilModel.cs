using System.Collections.Generic;

namespace Pizzaria.Authentication.Infra.Data.Models
{
    public class PerfilModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<PerfilPermissaoModel> PerfilPermissao { get; set; }
    }
}
