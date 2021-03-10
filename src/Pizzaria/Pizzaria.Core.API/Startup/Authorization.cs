using Microsoft.Extensions.DependencyInjection;

namespace Pizzaria.Core.API.Startup
{
    public static class Authorization
    {
        public static IServiceCollection AddJwtAuthorization(this IServiceCollection services)
        {
            return services.AddAuthorization(options =>
            {             
                options.AddPolicy("DashBoard", builder => { builder.RequireClaim("DashBoard", "DBD"); });
                options.AddPolicy("Pedido", builder => { builder.RequireClaim("Pedido", "PDS"); });
                options.AddPolicy("Produto", builder => { builder.RequireClaim("Produto", "PTS"); });
                options.AddPolicy("Clientes", builder => { builder.RequireClaim("Clientes", "CLS"); });
                options.AddPolicy("Preparos", builder => { builder.RequireClaim("Preparos", "PRS"); });
                options.AddPolicy("Relatórios", builder => { builder.RequireClaim("Relatórios", "RLS"); });
                options.AddPolicy("Adiministracao", builder => { builder.RequireClaim("Adiministracao", "ADM"); });
                options.AddPolicy("Usuarios", builder => { builder.RequireClaim("Usuarios", "USR"); });               
            });
        }
    }
}
