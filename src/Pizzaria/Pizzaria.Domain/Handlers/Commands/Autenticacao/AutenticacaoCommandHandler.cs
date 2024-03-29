﻿using FluentValidation.Results;
using MediatR;
using Pizzaria.Domain.Commands.Autenticacao;
using Pizzaria.Domain.Factories.Autenticacao;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Interfaces.Services;
using Pizzaria.Domain.Response.Autenticacao;
using Pizzaria.Domain.Validators.Autenticacao;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Commands.Autenticacao
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
                    return Task.FromResult(AutenticarResponseFactory.Criar(usuario, token));
                }

            }
            
            return Task.FromResult(new AutenticarResponse() { Sucesso = false, Mensagem = result.Errors.Any() ? result.Errors.Select(x => x.ErrorMessage).ToList() : new List<string>() { "Usuário ou senha inválidos" } });
        }
    }
}
