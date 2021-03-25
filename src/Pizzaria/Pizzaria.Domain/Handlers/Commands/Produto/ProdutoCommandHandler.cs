using FluentValidation.Results;
using MediatR;
using Pizzaria.Domain.Commands.Produto;
using Pizzaria.Domain.Factories.Produtos;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Response.Produto;
using Pizzaria.Domain.Validators.Produto;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Commands.Produto
{
    public class ProdutoCommandHandler :
            IRequestHandler<CadastrarProdutoCommand, CadastrarProdutoResponse>,
            IRequestHandler<AtualizarProdutoCommand, AtualizarProdutoResponse>,
            IRequestHandler<DeletarProdutoCommand, DeletarProdutoResponse>
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        public ProdutoCommandHandler(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        }
        public Task<CadastrarProdutoResponse> Handle(CadastrarProdutoCommand command, CancellationToken cancellationToken)
        {
            CadastrarProdutoCommandValidator validator = new CadastrarProdutoCommandValidator(_produtoRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                var produto = ProdutoFactory.Criar(command);

                _produtoRepository.Adicionar(produto);
                _produtoRepository.Salvar();

                return Task.FromResult(new CadastrarProdutoResponse() { Sucesso = true, Mensagem = new List<string>() { "Produto cadastrado com sucesso" } });
            }

            return Task.FromResult(new CadastrarProdutoResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }

        public Task<AtualizarProdutoResponse> Handle(AtualizarProdutoCommand command, CancellationToken cancellationToken)
        {
            AtualizarProdutoCommandValidator validator = new AtualizarProdutoCommandValidator(_produtoRepository, _categoriaRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                var produto = _produtoRepository.ObterPorId(command.Id);

                produto.Alterar(command.Valor, command.Descricao, command.CategoriaId);

                _produtoRepository.Atualizar(produto);

                _produtoRepository.Salvar();

                return Task.FromResult(new AtualizarProdutoResponse() { Sucesso = true, Mensagem = new List<string>() { "Produto atualizado com sucesso" } });
            }

            return Task.FromResult(new AtualizarProdutoResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }

        public Task<DeletarProdutoResponse> Handle(DeletarProdutoCommand command, CancellationToken cancellationToken)
        {
            DeletarProdutoCommandValidator validator = new DeletarProdutoCommandValidator(_produtoRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {
                _produtoRepository.Remover(command.Id);
                _produtoRepository.Salvar();

                return Task.FromResult(new DeletarProdutoResponse() { Sucesso = true, Mensagem = new List<string>() { "Produto deletada com sucesso" } });
            }

            return Task.FromResult(new DeletarProdutoResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }
    }
}
