

using Pizzaria.Core.Domain.Entities;
using Pizzaria.Core.Domain.ValueObjects;

namespace Pizzaria.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public int Id { get; private set; }
        public Email Email { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Senha { get; private set; }
        public int PerfilId { get; private set; }
        public int Telefone { get; private set; }
        public int DDD { get; private set; }
        public virtual Perfil Perfil { get; private set; }
    }
}
