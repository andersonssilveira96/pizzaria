using MediatR;
using Pizzaria.Authentication.Domain.Command;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Authentication.Domain.Handlers.Commands
{
    public class AutenticacaoCommandHandler 
        : IRequestHandler<AutenticarCommand, bool>
    {
        public Task<bool> Handle(AutenticarCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }
    }
}
