using Pizzaria.Domain.Commands.Produto;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Domain.Factories.Produtos
{
    public static class ProdutoFactory
    {
        public static Produto Criar(CadastrarProdutoCommand command)
        {
            return new Produto(command.Valor, command.Descricao, command.CategoriaId, command.UsuarioInclusaoId);
        }
    }
}
