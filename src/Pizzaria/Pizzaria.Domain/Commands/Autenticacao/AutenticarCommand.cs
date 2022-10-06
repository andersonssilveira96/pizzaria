using MediatR;
using Pizzaria.Domain.Response;
using Pizzaria.Domain.Response.Autenticacao;

namespace Pizzaria.Domain.Commands.Autenticacao
{
    public class AutenticarCommand : IRequest<AutenticarResponse>
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
