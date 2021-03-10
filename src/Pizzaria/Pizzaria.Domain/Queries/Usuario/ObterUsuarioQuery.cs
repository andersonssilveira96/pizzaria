using MediatR;
using Pizzaria.Domain.Response.Usuario;

namespace Pizzaria.Domain.Queries.Usuario
{
    public class ObterUsuarioQuery : IRequest<BaseUsuarioResponse>
    {
        public int Id { get; set; }
    }
}
