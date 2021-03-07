

using Pizzaria.Core.Domain.ValueObjects;

namespace Pizzaria.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; private set; }
        public Email Email { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Senha { get; private set; }
        public int PerfilId { get; private set; }
        public virtual Perfil Perfil { get; private set; }
    }
}
