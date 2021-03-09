using FluentValidation.Results;
using MediatR;
using Pizzaria.Domain.Commands.Usuario;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Response.Usuario;
using Pizzaria.Domain.Validators.Usuario;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Commands.Usuario
{
    public class UsuarioCommandHandler
        : IRequestHandler<CadastrarUsuarioCommand, CadastrarUsuarioResponse>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioCommandHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public Task<CadastrarUsuarioResponse> Handle(CadastrarUsuarioCommand command, CancellationToken cancellationToken)
        {
            CadastrarUsuarioCommandValidator validator = new CadastrarUsuarioCommandValidator();
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                return Task.FromResult(new CadastrarUsuarioResponse());
            }

            return Task.FromResult(new CadastrarUsuarioResponse());
        }
    }
}
