using Pizzaria.Core.Domain.Response;

namespace Pizzaria.Domain.Response.TipoPedido
{
    public class TipoPedidoResponse : BaseResponse
    {
        public int Id { get; set; }
        public string Descricao { get; set; }        
    }
  
}
