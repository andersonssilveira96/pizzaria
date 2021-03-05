using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Authentication.Domain.Entities;

namespace Pizzaria.Authentication.Infra.Data.Configs
{
    public class PerfilConfig : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Descricao).IsRequired();  
        }
    }
}
