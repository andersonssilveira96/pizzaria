using FluentValidation.Results;
using MediatR;
using Pizzaria.Domain.Commands.Produto;
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
        public ProdutoCommandHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public Task<CadastrarProdutoResponse> Handle(CadastrarProdutoCommand command, CancellationToken cancellationToken)
        {
            CadastrarProdutoCommandValidator validator = new CadastrarProdutoCommandValidator(_produtoRepository);
            ValidationResult result = validator.Validate(command);

            if (result.IsValid)
            {              

                return Task.FromResult(new CadastrarProdutoResponse() { Sucesso = true, Mensagem = new List<string>() { "Categoria cadastrada com sucesso" } });
            }

            return Task.FromResult(new CadastrarProdutoResponse() { Sucesso = false, Mensagem = result.Errors.Select(x => x.ErrorMessage).ToList() });
        }

        public Task<AtualizarProdutoResponse> Handle(AtualizarProdutoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<DeletarProdutoResponse> Handle(DeletarProdutoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
