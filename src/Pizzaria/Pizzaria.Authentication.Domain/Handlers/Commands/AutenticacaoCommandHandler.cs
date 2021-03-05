using FluentValidation.Results;
using MediatR;
using Pizzaria.Authentication.Domain.Commands;
using Pizzaria.Authentication.Domain.Interfaces.Repositories;
using Pizzaria.Authentication.Domain.Response;
using Pizzaria.Authentication.Domain.Validators;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Authentication.Domain.Handlers.Commands
{
    public class AutenticacaoCommandHandler 
        : IRequestHandler<AutenticarCommand, AutenticarResponse>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public AutenticacaoCommandHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public Task<AutenticarResponse> Handle(AutenticarCommand command, CancellationToken cancellationToken)
        {
            AutenticarCommandValidator validator = new AutenticarCommandValidator();
            ValidationResult result = validator.Validate(command);

            if(result.IsValid)
            {
                _usuarioRepository.Autenticar(command);
            }

            return Task.FromResult(new AutenticarResponse() { Id = 1, Nome = "Teste de usuário", Token = Guid.NewGuid().ToString() });
        }
    }
}
