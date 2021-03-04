namespace Pizzaria.Authentication.Domain.Entities
{
    public class PerfilPermissao
    {
        public int Id { get; private set; }
        public int PerfilId { get; private set; }
        public virtual Perfil Perfil { get; private set; }
        public int PermissaoId { get; private set; }
        public virtual Permissao Permissao { get; private set; }

    }
}
