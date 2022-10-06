using Pizzaria.Core.Domain.Entities;
using System.Collections.Generic;

namespace Pizzaria.Domain.Entities
{
    public class Permissao : EntityBase
    {      
        public string Descricao { get; private set; }
        public string Abreviacao { get; private set; }
        public virtual ICollection<PerfilPermissao> PerfilPermissao { get; private set; }
    }
}
