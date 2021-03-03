using Pizzaria.Authentication.Domain.ValueObjects;

namespace Pizzaria.Authentication.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; private set; }
        public Email Email { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Senha { get; private set; }
        public Perfil Perfil { get; private set; }
    }
}
