
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pizzaria.Authentication.Domain.Entities;

namespace Pizzaria.Authentication.Infra.Data.Context
{
    public class AutenticacaoContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Permissao> Permissao { get; set; }
        public DbSet<PerfilPermissao> PerfilPermissao { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public AutenticacaoContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("db"));
            optionsBuilder.UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AutenticacaoContext).Assembly);           
        }
    }
}
