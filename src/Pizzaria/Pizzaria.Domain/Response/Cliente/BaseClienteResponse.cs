using Pizzaria.Core.Domain.Response;

namespace Pizzaria.Domain.Response.Cliente
{
    public class BaseClienteResponse : BaseResponse
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public int DDD { get; set; }
        public int Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}
