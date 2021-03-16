using Pizzaria.Core.Domain.Entities;

namespace Pizzaria.Domain.Entities
{
    public class Endereco : EntityBase
    {
        public Endereco(string rua, int numero, string complemento, string bairro, string cidade, string estado, string cep, int usuarioInclusaoId)
        {
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
            UsuarioInclusaoId = usuarioInclusaoId;
        }
        protected Endereco()
        {
        }
        public void Alterar(string rua, int numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
        }
        public int Id { get; private set; }
        public string Rua { get; private set; }
        public int Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; set; }
        public int ClienteId { get; private set; }
        public virtual Cliente Cliente { get; private set; }
        public virtual Usuario UsuarioInclusao { get; private set; }
    }
}
