using FluentValidation.Results;
using MediatR;
using Pizzaria.Domain.Commands.Categoria;
using Pizzaria.Domain.Factories.Categorias;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Response.Categoria;
using Pizzaria.Domain.Validators.Categoria;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Commands.Categoria
{
    public class CategoriaCommandHandler :
            IRequestHandler<CadastrarCategoriaCommand, CadastrarCategoriaResponse>,
            IRequestHandler<AtualizarCategoriaCommand, AtualizarCategoriaResponse>,
            IRequestHandler<DeletarCategoriaCommand, DeletarCategoriaResponse>
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IProdutoRepository _produtoRepository;
        public CategoriaCommandHandler(ICategoriaRepository categoriaRepository, IProdutoRepository produtoRepository)
        {
            _categoriaRepository = categoriaRepository;
            _produtoRepository = produtoRepository;
        }
        public Task<CadastrarCategoriaResponse> Handle(CadastrarCategoriaCommand command, CancellationToken cancellationToken)
        {
            CadastrarCategoriaCommandValidator validator = new CadastrarCategoriaCommandValidator(_categoriaRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                var categoria = CategoriaFactory.Criar(command);

                _categoriaRepository.Adicionar(categoria);
                _categoriaRepository.Salvar();

                return Task.FromResult(new CadastrarCategoriaResponse() { Sucesso = true, Mensagem = new List<string>() { "Categoria cadastrada com sucesso" } });
            }

            return Task.FromResult(new CadastrarCategoriaResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }

        public Task<AtualizarCategoriaResponse> Handle(AtualizarCategoriaCommand command, CancellationToken cancellationToken)
        {
            AtualizarCategoriaCommandValidator validator = new AtualizarCategoriaCommandValidator(_categoriaRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                var categoria = _categoriaRepository.ObterPorId(command.Id);

                categoria.Alterar(command.Descricao, command.Icone);

                _categoriaRepository.Atualizar(categoria);

                _categoriaRepository.Salvar();

                return Task.FromResult(new AtualizarCategoriaResponse() { Sucesso = true, Mensagem = new List<string>() { "Categoria atualizada com sucesso" } });
            }

            return Task.FromResult(new AtualizarCategoriaResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }

        public Task<DeletarCategoriaResponse> Handle(DeletarCategoriaCommand command, CancellationToken cancellationToken)
        {
            DeletarCategoriaCommandValidator validator = new DeletarCategoriaCommandValidator(_categoriaRepository, _produtoRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                _categoriaRepository.Remover(command.Id);
                _categoriaRepository.Salvar();

                return Task.FromResult(new DeletarCategoriaResponse() { Sucesso = true, Mensagem = new List<string>() { "Categoria deletada com sucesso" } });
            }

            return Task.FromResult(new DeletarCategoriaResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }
    }
}
