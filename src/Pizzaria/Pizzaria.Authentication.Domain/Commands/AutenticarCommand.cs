using MediatR;
using Pizzaria.Authentication.Domain.Response;

namespace Pizzaria.Authentication.Domain.Commands
{
    public class AutenticarCommand : IRequest<AutenticarResponse>
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
