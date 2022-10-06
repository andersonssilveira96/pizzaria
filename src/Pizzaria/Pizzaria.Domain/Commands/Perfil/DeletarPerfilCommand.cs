using MediatR;
using Pizzaria.Domain.Response.Perfil;

namespace Pizzaria.Domain.Commands.Perfil
{
    public class DeletarPerfilCommand : BasePerfilCommand, IRequest<DeletarPerfilResponse>
    {
    }
}
