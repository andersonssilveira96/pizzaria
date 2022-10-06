using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;
using System;

namespace Pizzaria.Infra.Data.Configs
{
    public class TipoPedidoConfig : IEntityTypeConfiguration<TipoPedido>
    {
        public void Configure(EntityTypeBuilder<TipoPedido> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Descricao).IsRequired();

            builder.Property(p => p.Ativo)
               .IsRequired()
               .HasDefaultValue(true);

            builder.Property(p => p.DataInclusao)
               .IsRequired()
               .HasDefaultValue(DateTime.Now);          

            builder.HasQueryFilter(e => e.Ativo == true);

        }
    }   
}
