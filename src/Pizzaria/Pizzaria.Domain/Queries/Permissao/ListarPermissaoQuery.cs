using MediatR;
using Pizzaria.Domain.Response.Permissao;
using System.Collections.Generic;

namespace Pizzaria.Domain.Queries.Permissao
{
    public class ListarPermissaoQuery : IRequest<IEnumerable<PermissaoResponse>>
    {
    }
}
