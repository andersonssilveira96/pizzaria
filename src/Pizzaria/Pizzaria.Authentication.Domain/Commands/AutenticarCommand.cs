using MediatR;

namespace Pizzaria.Authentication.Domain.Commands
{
    public class AutenticarCommand : IRequest<bool>
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
