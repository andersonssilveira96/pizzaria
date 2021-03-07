using MediatR;
using Pizzaria.Domain.Response;

namespace Pizzaria.Domain.Commands
{
    public class AutenticarCommand : IRequest<AutenticarResponse>
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
