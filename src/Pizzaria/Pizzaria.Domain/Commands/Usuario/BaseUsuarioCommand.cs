using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Commands.Usuario
{
    public class BaseUsuarioCommand
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Senha { get; set; }
        public int PerfilId { get; set; }
        public int Telefone { get; set; }
        public int DDD { get; set; }
        public int UsuarioInclusaoId { get; set; }
    }
}
