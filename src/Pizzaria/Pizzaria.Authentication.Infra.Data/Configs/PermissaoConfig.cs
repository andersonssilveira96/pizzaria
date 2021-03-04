using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Authentication.Infra.Data.Models;

namespace Pizzaria.Authentication.Infra.Data.Configs
{
    public class PermissaoConfig : IEntityTypeConfiguration<PermissaoModel>
    {
        public void Configure(EntityTypeBuilder<PermissaoModel> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Abreviacao).IsRequired();
            builder.Property(e => e.Nome).IsRequired();      
        }
    }
}
