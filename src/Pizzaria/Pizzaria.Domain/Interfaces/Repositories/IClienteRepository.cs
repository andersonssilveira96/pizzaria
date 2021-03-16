using Pizzaria.Core.Domain;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Queries.Cliente;
using System.Collections.Generic;

namespace Pizzaria.Domain.Interfaces.Repositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        bool VerificarClienteExistente(int id);
        bool VerificarEmailExistente(int id, string email);
        IEnumerable<Cliente> ObterTodos(ListarClienteQuery query);
    }
}
