using FluentValidation.Results;
using MediatR;
using Pizzaria.Domain.Commands;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Interfaces.Services;
using Pizzaria.Domain.Response;
using Pizzaria.Domain.Validators;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Commands
{
    public class AutenticacaoCommandHandler 
        : IRequestHandler<AutenticarCommand, AutenticarResponse>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ITokenService _tokenService;
        public AutenticacaoCommandHandler(IUsuarioRepository usuarioRepository, ITokenService tokenService)
        {
            _usuarioRepository = usuarioRepository;
            _tokenService = tokenService;
        }
        public Task<AutenticarResponse> Handle(AutenticarCommand command, CancellationToken cancellationToken)
        {
            AutenticarCommandValidator validator = new AutenticarCommandValidator();
            ValidationResult result = validator.Validate(command);

            if(result.IsValid)
            {
                var usuario = _usuarioRepository.Autenticar(command);

                if (usuario != null)
                {
                    var token = _tokenService.GerarToken(usuario);
                    return Task.FromResult(new AutenticarResponse() { Id = usuario.Id, Nome = usuario.Nome, Email = usuario.Email.Valor, Token = token, Sucesso = true, Mesagem = new List<string>() { "Usuário autenticado com sucesso" } });
                }

            }
            
            return Task.FromResult(new AutenticarResponse() { Sucesso = false, Mesagem = result.Errors.Any() ? result.Errors.Select(x => x.ErrorMessage).ToList() : new List<string>() { "Usuário ou senha inválidos" } });
        }
    }
}
