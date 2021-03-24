using Pizzaria.Core.Domain.Response;

namespace Pizzaria.Domain.Response.Produto
{
    public class ProdutoCompletoResponse : BaseResponse
    {
        public int Id { get; set; }
        public string Descricao { get; set; }        
    }
}
