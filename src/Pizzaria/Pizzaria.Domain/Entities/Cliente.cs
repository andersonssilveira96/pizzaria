using Pizzaria.Core.Domain.Entities;
using Pizzaria.Core.Domain.ValueObjects;

namespace Pizzaria.Domain.Entities
{
    public class Cliente : EntityBase
    {
        protected Cliente()
        {
        }

        public Cliente(CPF cpf, Email email, string nome, int ddd, int telefone, int usuarioInclusaoId, Endereco endereco)
        {
            CPF = cpf;
            Email = email;
            Nome = nome;
            DDD = ddd;
            Telefone = telefone;
            UsuarioInclusaoId = usuarioInclusaoId;
            Endereco = endereco;
        }

        public void Alterar(CPF cpf, Email email, string nome, int ddd, int telefone)
        {
            CPF = cpf;
            Email = email;
            Nome = nome;
            DDD = ddd;
            Telefone = telefone;
        }
        public int Id { get; private set; }
        public CPF CPF { get; private set; }
        public Email Email { get; private set; }
        public string Nome { get; private set; }
        public int DDD { get; private set; }
        public int Telefone { get; private set; }
        public int EnderecoId { get; private set; }
        public virtual Endereco Endereco { get; private set;}
        public virtual Usuario UsuarioInclusao { get; private set; }
    }
}

