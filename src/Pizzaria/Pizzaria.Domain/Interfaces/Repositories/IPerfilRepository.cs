using Pizzaria.Core.Domain;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Domain.Interfaces.Repositories
{
    public interface IPerfilRepository : IRepository<Perfil>
    {
        public bool VerificarPerfilExistente(int id);
        public bool VerificarPerfilExistente(int id, string descricao);
    }
}
