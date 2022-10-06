using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Infra.Data.Data.Configs
{
    public class PerfilConfig : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Descricao).IsRequired();
            builder.HasQueryFilter(e => e.Ativo == true);
        }
    }
}
