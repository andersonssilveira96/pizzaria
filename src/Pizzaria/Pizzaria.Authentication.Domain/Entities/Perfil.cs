using System.Collections.Generic;

namespace Pizzaria.Authentication.Domain.Entities
{
    public class Perfil
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public IEnumerable<Permissao> Permissoes { get; private set; }
    }
}
