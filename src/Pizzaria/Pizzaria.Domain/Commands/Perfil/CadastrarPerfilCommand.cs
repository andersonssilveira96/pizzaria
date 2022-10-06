using MediatR;
using Pizzaria.Domain.Response.Perfil;

namespace Pizzaria.Domain.Commands.Perfil
{
    public class CadastrarPerfilCommand : BasePerfilCommand, IRequest<CadastrarPerfilResponse>
    {
        public int UsuarioInclusaoId { get; set; }
    }
}
