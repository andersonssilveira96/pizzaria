using Pizzaria.Domain.Entities;

namespace Pizzaria.Domain.Interfaces.Services
{
    public interface ITokenService
    {
        string GerarToken(Usuario usuario);
    }
}
