using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Produto
{
    public class CadastrarProdutoCommandValidator : BaseProdutoCommandValidator
    {
        public CadastrarProdutoCommandValidator(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
        }
    }    
}
