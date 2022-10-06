using MediatR;
using Pizzaria.Domain.Response.Usuario;

namespace Pizzaria.Domain.Commands.Usuario
{
    public class CadastrarUsuarioCommand : BaseUsuarioCommand, IRequest<CadastrarUsuarioResponse>
    {        
    }
}
