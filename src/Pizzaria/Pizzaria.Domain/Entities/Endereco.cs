using Pizzaria.Core.Domain.Entities;

namespace Pizzaria.Domain.Entities
{
    public class Endereco : EntityBase
    {
        public Endereco(string rua, int numero, string complemento, string bairro, string cidade, string estado, int cep)
        {
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;            
        }
        protected Endereco()
        {
        }
        public int Id { get; private set; }
        public string Rua { get; private set; }
        public int Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public int CEP { get; set; }
        public int ClienteId { get; private set; }
        public virtual Cliente Cliente { get; private set;}
    }
}
