using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Infra.Data.Data.Configs
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(p => p.Id);

            builder.OwnsOne(p => p.Email, x => 
            { 
                x.Property(x => x.Valor).HasColumnName("Email");                
            });
                

            builder.Property(p => p.Nome).IsRequired();
            builder.Property(p => p.Senha).IsRequired();
            builder.Property(p => p.Sobrenome).IsRequired();

            builder.HasOne(p => p.Perfil).WithMany().HasForeignKey(x => x.PerfilId).IsRequired();
        }
    }
}
