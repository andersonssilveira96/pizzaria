using System;

namespace Pizzaria.Core.Domain.Entities
{
    public abstract class EntityBase
    {
        protected bool Ativo { get; set; }
        protected DateTime DataInclusao { get; set; }
        protected int UsuarioInclusao { get; set; }

    }
}
