using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Infra.Data.Configs
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);           

            builder.Property(p => p.Bairro).IsRequired();
            builder.Property(p => p.CEP).IsRequired();
            builder.Property(p => p.Cidade).IsRequired();
            builder.Property(p => p.Complemento).IsRequired();
            builder.Property(p => p.Estado).IsRequired();
            builder.Property(p => p.Numero).IsRequired();
            builder.Property(p => p.Rua).IsRequired();
        }
    }
}
