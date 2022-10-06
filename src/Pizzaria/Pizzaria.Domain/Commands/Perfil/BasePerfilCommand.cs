using System.Collections.Generic;

namespace Pizzaria.Domain.Commands.Perfil
{
    public class BasePerfilCommand
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<int> Permissao { get; set; }
    }
}
