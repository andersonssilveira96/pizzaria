
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Pizzaria.Authentication.Infra.Data.Context
{
    public class AutenticacaoContext : DbContext
    {
        private readonly IConfiguration _configuration;

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
            // modelBuilder.ApplyConfiguration(new UsuarioConfig());
            // modelBuilder.ApplyConfiguration(new EscolaridadeConfig());
        }
    }
}
