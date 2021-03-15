using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;
using System;

namespace Pizzaria.Infra.Data.Configs
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.OwnsOne(p => p.CPF, x =>
            {
                x.Property(x => x.Valor).HasColumnName("CPF");
            });

            builder.OwnsOne(p => p.Email, x =>
            {
                x.Property(x => x.Valor).HasColumnName("Email");
            });

            builder.Property(p => p.Telefone).IsRequired();
            builder.Property(p => p.DDD).IsRequired();
            builder.Property(p => p.Nome).IsRequired();        

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

            builder.HasOne(p => p.Endereco)
                   .WithOne(x => x.Cliente)
                   .HasForeignKey<Endereco>(x => x.ClienteId);
        }
    }
}
