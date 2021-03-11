using MediatR;
using Pizzaria.Domain.Response.Perfil;

namespace Pizzaria.Domain.Queries.Perfil
{
    public class ObterPerfilQuery : IRequest<PerfilCompletoResponse>
    {
        public int Id { get; set; }
    }
}
