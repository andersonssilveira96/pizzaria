using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Perfil
{
    public class AtualizarPerfilCommandValidator : BasePerfilCommandValidator
    {
        public AtualizarPerfilCommandValidator(IPerfilRepository perfilRepository) : base(perfilRepository)
        {
        }
    }
}
