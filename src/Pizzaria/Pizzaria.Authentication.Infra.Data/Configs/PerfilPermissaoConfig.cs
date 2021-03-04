using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Authentication.Infra.Data.Models;

namespace Pizzaria.Authentication.Infra.Data.Configs
{
    public class PerfilPermissaoConfig : IEntityTypeConfiguration<PerfilPermissaoModel>
    {
        public void Configure(EntityTypeBuilder<PerfilPermissaoModel> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.Perfil).WithMany(e => e.PerfilPermissao).HasForeignKey(e => e.PerfilId);
            builder.HasOne(e => e.Permissao).WithMany(e => e.PerfilPermissao).HasForeignKey(e => e.PermissaoId);
        }
    }
}
