using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Authentication.Domain.Entities;

namespace Pizzaria.Authentication.Infra.Data.Configs
{
    public class PermissaoConfig : IEntityTypeConfiguration<Permissao>
    {
        public void Configure(EntityTypeBuilder<Permissao> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Abreviacao).IsRequired();
            builder.Property(e => e.Nome).IsRequired();      
        }
    }
}
