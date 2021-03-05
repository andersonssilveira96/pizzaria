using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Authentication.Domain.Entities;

namespace Pizzaria.Authentication.Infra.Data.Configs
{
    public class PerfilPermissaoConfig : IEntityTypeConfiguration<PerfilPermissao>
    {
        public void Configure(EntityTypeBuilder<PerfilPermissao> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.Perfil).WithMany(e => e.PerfilPermissao).HasForeignKey(e => e.PerfilId);
            builder.HasOne(e => e.Permissao).WithMany(e => e.PerfilPermissao).HasForeignKey(e => e.PermissaoId);
        }
    }
}
