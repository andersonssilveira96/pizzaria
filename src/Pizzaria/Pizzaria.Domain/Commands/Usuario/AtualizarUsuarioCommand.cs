using MediatR;
using Pizzaria.Domain.Response.Usuario;

namespace Pizzaria.Domain.Commands.Usuario
{
    public class AtualizarUsuarioCommand : BaseUsuarioCommand, IRequest<AtualizarUsuarioResponse>
    {
    }
}
