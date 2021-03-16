using FluentValidation.Results;
using MediatR;
using Pizzaria.Domain.Commands.Perfil;
using Pizzaria.Domain.Factories.Perfis;
using Pizzaria.Domain.Factories.PermissaoPerfil;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Response.Perfil;
using Pizzaria.Domain.Validators.Perfil;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Commands.Perfil
{
    public class PerfilCommandHandler :
          IRequestHandler<CadastrarPerfilCommand, CadastrarPerfilResponse>,
          IRequestHandler<AtualizarPerfilCommand, AtualizarPerfilResponse>,
          IRequestHandler<DeletarPerfilCommand, DeletarPerfilResponse>
    {

        private readonly IPerfilRepository _perfilRepository;
        private readonly IPerfilPermissaoRepository _perfilPermissaoRepository;
        public PerfilCommandHandler(IPerfilRepository perfilRepository, IPerfilPermissaoRepository perfilPermissaoRepository)
        {
            _perfilRepository = perfilRepository;
            _perfilPermissaoRepository = perfilPermissaoRepository;
        }
        public Task<CadastrarPerfilResponse> Handle(CadastrarPerfilCommand command, CancellationToken cancellationToken)
        {
            CadastrarPerfilCommandValidator validator = new CadastrarPerfilCommandValidator(_perfilRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                var perfil = PerfilFactory.Criar(command);

                var obj = _perfilRepository.Adicionar(perfil);
                _perfilRepository.Salvar();

                var perfilPermissao = PerfilPermissaoFactory.Criar(obj.Id, command.Permissao.ToList());

                foreach(var item in perfilPermissao)
                {
                    _perfilPermissaoRepository.Adicionar(item);
                }

                _perfilPermissaoRepository.Salvar();

                return Task.FromResult(new CadastrarPerfilResponse() { Sucesso = true, Mensagem = new List<string>() { "Perfil cadastrado com sucesso" } });
            }

            return Task.FromResult(new CadastrarPerfilResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }
        public Task<AtualizarPerfilResponse> Handle(AtualizarPerfilCommand command, CancellationToken cancellationToken)
        {
            AtualizarPerfilCommandValidator validator = new AtualizarPerfilCommandValidator(_perfilRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                var perfil = _perfilRepository.ObterPorId(command.Id);
                
                perfil.Alterar(command.Descricao);

                _perfilRepository.Atualizar(perfil);

                _perfilPermissaoRepository.DeletarPorPerfilId(perfil.Id);

                var perfilPermissao = PerfilPermissaoFactory.Criar(perfil.Id, command.Permissao.ToList());

                foreach (var item in perfilPermissao)
                {                    
                    _perfilPermissaoRepository.Adicionar(item);
                }                

                _perfilRepository.Salvar();

                return Task.FromResult(new AtualizarPerfilResponse() { Sucesso = true, Mensagem = new List<string>() { "Perfil atualizado com sucesso" } });
            }

            return Task.FromResult(new AtualizarPerfilResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }
        public Task<DeletarPerfilResponse> Handle(DeletarPerfilCommand command, CancellationToken cancellationToken)
        {
            DeletarPerfilCommandValidator validator = new DeletarPerfilCommandValidator(_perfilRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                _perfilRepository.Remover(command.Id);
                _perfilRepository.Salvar();

                return Task.FromResult(new DeletarPerfilResponse() { Sucesso = true, Mensagem = new List<string>() { "Perfil deletado com sucesso" } });
            }

            return Task.FromResult(new DeletarPerfilResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }        
    }
}
