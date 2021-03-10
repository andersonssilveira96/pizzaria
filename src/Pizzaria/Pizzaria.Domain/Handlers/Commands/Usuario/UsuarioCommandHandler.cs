﻿using FluentValidation.Results;
using MediatR;
using Pizzaria.Core.Domain.ValueObjects;
using Pizzaria.Domain.Commands.Usuario;
using Pizzaria.Domain.Factories.Usuarios;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Response.Usuario;
using Pizzaria.Domain.Validators.Usuario;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Commands.Usuario
{
    public class UsuarioCommandHandler :
            IRequestHandler<CadastrarUsuarioCommand, CadastrarUsuarioResponse>,
            IRequestHandler<AtualizarUsuarioCommand, AtualizarUsuarioResponse>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioCommandHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public Task<CadastrarUsuarioResponse> Handle(CadastrarUsuarioCommand command, CancellationToken cancellationToken)
        {
            CadastrarUsuarioCommandValidator validator = new CadastrarUsuarioCommandValidator(_usuarioRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                var usuario = UsuarioFactory.Criar(command);
               
                _usuarioRepository.Adicionar(usuario);
                _usuarioRepository.Salvar();

                return Task.FromResult(new CadastrarUsuarioResponse() { Sucesso = true, Mensagem = new List<string>() { "Usuário cadastrado com sucesso" } });
            }

            return Task.FromResult(new CadastrarUsuarioResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }

        public Task<AtualizarUsuarioResponse> Handle(AtualizarUsuarioCommand command, CancellationToken cancellationToken)
        {
            AtualizarUsuarioCommandValidator validator = new AtualizarUsuarioCommandValidator(_usuarioRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                var usuario = _usuarioRepository.ObterPorId(command.Id);
                
                usuario.Alterar(new Email(command.Email), command.Nome, command.Sobrenome, command.Senha, command.PerfilId, command.Telefone, command.DDD);

                _usuarioRepository.Atualizar(usuario);
                _usuarioRepository.Salvar();

                return Task.FromResult(new AtualizarUsuarioResponse() { Sucesso = true, Mensagem = new List<string>() { "Usuário atualizado com sucesso" } });
            }

            return Task.FromResult(new AtualizarUsuarioResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }
    }
}
