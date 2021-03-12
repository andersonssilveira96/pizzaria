using Pizzaria.Core.Domain;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Domain.Interfaces.Repositories
{
    public interface IPerfilPermissaoRepository : IRepository<PerfilPermissao>
    {
        void DeletarPorPerfilId(int PerfilId);
    }
}
