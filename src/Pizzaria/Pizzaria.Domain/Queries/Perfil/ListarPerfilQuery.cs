using MediatR;
using Pizzaria.Domain.Response.Perfil;
using System.Collections.Generic;

namespace Pizzaria.Domain.Queries.Perfil
{
    public class ListarPerfilQuery : IRequest<IEnumerable<BasePerfilResponse>>
    {
    }
}
