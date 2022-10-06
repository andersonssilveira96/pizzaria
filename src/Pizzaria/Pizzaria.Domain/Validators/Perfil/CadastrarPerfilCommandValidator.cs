using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Perfil
{
    public class CadastrarPerfilCommandValidator : BasePerfilCommandValidator
    {
        public CadastrarPerfilCommandValidator(IPerfilRepository perfilRepository) : base(perfilRepository)
        {
        }
    }
}
