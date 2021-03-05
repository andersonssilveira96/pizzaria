using Pizzaria.Authentication.Domain.Commands;
using Pizzaria.Authentication.Domain.Entities;
using Pizzaria.Authentication.Domain.Response;
using Pizzaria.Core.Domain;

namespace Pizzaria.Authentication.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        AutenticarResponse Autenticar(AutenticarCommand usuarioCommand);
    }
}
