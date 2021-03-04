using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Authentication.Infra.Data.Models;

namespace Pizzaria.Authentication.Infra.Data.Configs
{
    public class PerfilConfig : IEntityTypeConfiguration<PerfilModel>
    {
        public void Configure(EntityTypeBuilder<PerfilModel> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Descricao).IsRequired();  
        }
    }
}
