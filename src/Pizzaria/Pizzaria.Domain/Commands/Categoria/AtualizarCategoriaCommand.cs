using MediatR;
using Pizzaria.Domain.Response.Categoria;

namespace Pizzaria.Domain.Commands.Categoria
{
    public class AtualizarCategoriaCommand : BaseCategoriaCommand, IRequest<AtualizarCategoriaResponse>
    {
    }
}
