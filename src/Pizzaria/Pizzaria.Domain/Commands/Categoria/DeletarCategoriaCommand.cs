using MediatR;
using Pizzaria.Domain.Response.Categoria;

namespace Pizzaria.Domain.Commands.Categoria
{
    public class DeletarCategoriaCommand : BaseCategoriaCommand, IRequest<DeletarCategoriaResponse>
    {
    }
}
