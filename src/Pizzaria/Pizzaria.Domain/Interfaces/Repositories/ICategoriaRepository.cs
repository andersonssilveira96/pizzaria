using Pizzaria.Core.Domain;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Domain.Interfaces.Repositories
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        public bool VerificarCategoriaExistente(int id);
        public bool VerificarCategoriaExistente(int id, string descricao);
    }
}
