using Pizzaria.Domain.Commands.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Commands.Cliente
{
    public class BaseClienteCommand
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public int DDD { get; set; }
        public int Telefone { get; set; }
        public int EnderecoId { get; set; }
        public BaseEnderecoCommand Endereco { get; set; }
        public int UsuarioInclusaoId { get; set; }

    }
}
