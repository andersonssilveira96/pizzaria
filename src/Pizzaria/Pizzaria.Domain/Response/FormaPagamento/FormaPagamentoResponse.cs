using Pizzaria.Core.Domain.Response;

namespace Pizzaria.Domain.Response.FormaPagamento
{
    public class FormaPagamentoResponse : BaseResponse
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
    
}
