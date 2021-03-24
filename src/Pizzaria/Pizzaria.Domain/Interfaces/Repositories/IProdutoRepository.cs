using Pizzaria.Core.Domain;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        bool VerificarProdutoComCategoria(int categoriaId);
        bool VerificarProdutoExistente(int id);
        bool VerificarProdutoExistente(int id, string descricao);
    }
}
