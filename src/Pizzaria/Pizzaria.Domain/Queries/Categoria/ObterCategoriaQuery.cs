using MediatR;
using Pizzaria.Domain.Response.Categoria;

namespace Pizzaria.Domain.Queries.Categoria
{
    public class ObterCategoriaQuery : IRequest<CategoriaCompletoResponse>
    {
        public int Id { get; set; }
    }
}
