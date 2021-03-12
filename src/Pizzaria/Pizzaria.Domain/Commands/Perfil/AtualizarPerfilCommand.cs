using MediatR;
using Pizzaria.Domain.Response.Perfil;

namespace Pizzaria.Domain.Commands.Perfil
{
    public class AtualizarPerfilCommand : BasePerfilCommand, IRequest<AtualizarPerfilResponse>
    {
    }
}
