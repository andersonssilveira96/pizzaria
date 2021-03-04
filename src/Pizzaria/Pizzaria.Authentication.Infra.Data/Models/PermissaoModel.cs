using System.Collections.Generic;

namespace Pizzaria.Authentication.Infra.Data.Models
{
    public class PermissaoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Abreviacao { get; set; }
        public virtual ICollection<PerfilPermissaoModel> PerfilPermissao { get; set; }
    }
}
