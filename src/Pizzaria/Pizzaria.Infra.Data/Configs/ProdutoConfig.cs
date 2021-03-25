using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;
using System;

namespace Pizzaria.Infra.Data.Configs
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(e => e.Descricao).IsRequired();

            builder.Property(e => e.Valor).IsRequired();

            builder.Property(p => p.Ativo)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(p => p.DataInclusao)
                .IsRequired()
                .HasDefaultValue(DateTime.Now);

            builder.HasOne(p => p.UsuarioInclusao)
                .WithMany()
                .HasForeignKey(x => x.UsuarioInclusaoId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasQueryFilter(x => x.Ativo == true);
        }
    }
}
