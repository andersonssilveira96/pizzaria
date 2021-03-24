using Pizzaria.Core.Domain;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        bool VerificarProdutoComCategoria(int categoriaId);
    }
}
