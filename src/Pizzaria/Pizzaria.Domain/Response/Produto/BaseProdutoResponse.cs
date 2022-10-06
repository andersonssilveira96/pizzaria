using Pizzaria.Core.Domain.Response;
using Pizzaria.Domain.Response.Categoria;

namespace Pizzaria.Domain.Response.Produto
{
    public class BaseProdutoResponse : BaseResponse
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public BaseCategoriaResponse Categoria { get; set; }
    }
}
