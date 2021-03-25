using Microsoft.AspNetCore.Http;

namespace Pizzaria.Domain.Commands.Produto
{
    public class BaseProdutoCommand
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }       
    }
}
