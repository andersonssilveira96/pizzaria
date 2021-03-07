using Pizzaria.Domain.Commands;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Response;
using Pizzaria.Core.Domain;

namespace Pizzaria.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario Autenticar(AutenticarCommand usuarioCommand);
    }
}
