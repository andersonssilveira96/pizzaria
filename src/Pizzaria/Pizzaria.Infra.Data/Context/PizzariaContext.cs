
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Infra.Data.Data.Context
{
    public class PizzariaContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Permissao> Permissao { get; set; }
        public DbSet<PerfilPermissao> PerfilPermissao { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public PizzariaContext(IConfiguration configuration)
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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PizzariaContext).Assembly);           
        }
    }
}
