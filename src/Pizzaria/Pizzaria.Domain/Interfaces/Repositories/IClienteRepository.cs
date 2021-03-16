using Pizzaria.Core.Domain;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Domain.Interfaces.Repositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        bool VerificarClienteExistente(int id);
        bool VerificarEmailExistente(int id, string email);
    }
}
