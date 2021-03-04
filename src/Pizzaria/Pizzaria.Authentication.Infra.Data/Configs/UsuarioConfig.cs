using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Authentication.Infra.Data.Models;

namespace Pizzaria.Authentication.Infra.Data.Configs
{
    public class UsuarioConfig : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.Nome).IsRequired();
            builder.Property(p => p.Senha).IsRequired();
            builder.Property(p => p.Sobrenome).IsRequired();

            builder.HasOne(p => p.Perfil).WithMany().HasForeignKey(x => x.PerfilId).IsRequired();
        }
    }
}
