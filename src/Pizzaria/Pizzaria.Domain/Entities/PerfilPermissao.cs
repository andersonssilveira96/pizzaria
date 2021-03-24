using Pizzaria.Core.Domain.Entities;

namespace Pizzaria.Domain.Entities
{
    public class PerfilPermissao : EntityBase
    {
        public PerfilPermissao(int perfilId, int permissaoId)
        {
            PerfilId = perfilId;
            PermissaoId = permissaoId;
            Ativo = true;
        }
        protected PerfilPermissao()
        {
        }
              
        public int PerfilId { get; private set; }
        public virtual Perfil Perfil { get; private set; }
        public int PermissaoId { get; private set; }
        public virtual Permissao Permissao { get; private set; }
    }
}
