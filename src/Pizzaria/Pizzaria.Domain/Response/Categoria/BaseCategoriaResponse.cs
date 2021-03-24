using Pizzaria.Core.Domain.Response;

namespace Pizzaria.Domain.Response.Categoria
{
    public class BaseCategoriaResponse : BaseResponse
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
