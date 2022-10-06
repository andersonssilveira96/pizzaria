using Pizzaria.Core.Domain.Response;
using Pizzaria.Domain.Response.Endereco;

namespace Pizzaria.Domain.Response.Cliente
{
    public class ClienteCompletoResponse : BaseClienteResponse
    {      
        public EnderecoCompletoResponse Endereco { get; set; }
    }
}
