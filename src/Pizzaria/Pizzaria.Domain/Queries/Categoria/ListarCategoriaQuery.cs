using MediatR;
using Pizzaria.Domain.Response.Categoria;
using System.Collections.Generic;

namespace Pizzaria.Domain.Queries.Categoria
{
    public class ListarCategoriaQuery : IRequest<IEnumerable<BaseCategoriaResponse>>
    {
    }
}
