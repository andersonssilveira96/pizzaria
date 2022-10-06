using Pizzaria.Core.Domain.Response;

namespace Pizzaria.Domain.Response.StatusPedido
{
    public class StatusPedidoResponse : BaseResponse
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }

}
