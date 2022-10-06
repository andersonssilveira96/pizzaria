using MediatR;
using Pizzaria.Domain.Response.Usuario;
using System.Collections.Generic;

namespace Pizzaria.Domain.Queries.Usuario
{
    public class ListarUsuariosQuery : IRequest<IEnumerable<BaseUsuarioResponse>>
    {
    }
}
