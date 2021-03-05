using Microsoft.Extensions.DependencyInjection;
using Pizzaria.Authentication.Domain.Interfaces.Repositories;
using Pizzaria.Authentication.Infra.Data.Context;
using Pizzaria.Authentication.Infra.Data.Repositories;

namespace Pizzaria.Authentication.Infra.IoC
{
    public static class NativeContainer
    {
        public static void Configure(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddDbContext<AutenticacaoContext>();
        }
    }
}
