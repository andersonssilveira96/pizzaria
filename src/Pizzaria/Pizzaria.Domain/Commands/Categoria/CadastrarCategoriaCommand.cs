using MediatR;
using Pizzaria.Domain.Response.Categoria;

namespace Pizzaria.Domain.Commands.Categoria
{
    public class CadastrarCategoriaCommand : BaseCategoriaCommand, IRequest<CadastrarCategoriaResponse>
    {
        public int UsuarioInclusaoId { get; set; }
    }
}
