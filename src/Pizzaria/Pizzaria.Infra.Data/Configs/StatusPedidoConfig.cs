using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;
using System;

namespace Pizzaria.Infra.Data.Configs
{
    public class StatusPedidoConfig : IEntityTypeConfiguration<StatusPedido>
    {
        public void Configure(EntityTypeBuilder<StatusPedido> builder)
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
