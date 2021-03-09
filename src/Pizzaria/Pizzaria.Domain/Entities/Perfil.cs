using Pizzaria.Core.Domain.Entities;
using System.Collections.Generic;

namespace Pizzaria.Domain.Entities
{
    public class Perfil : EntityBase
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public virtual ICollection<PerfilPermissao> PerfilPermissao { get; private set; }
    }
}
