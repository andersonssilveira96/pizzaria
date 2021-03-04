
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pizzaria.Authentication.Infra.Data.Models;

namespace Pizzaria.Authentication.Infra.Data.Context
{
    public class AutenticacaoContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<PerfilModel> Perfil { get; set; }
        public DbSet<PermissaoModel> Permissao { get; set; }
        public DbSet<PerfilPermissaoModel> PerfilPermissao { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }

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
