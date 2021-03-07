﻿using Microsoft.Extensions.DependencyInjection;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Interfaces.Services;
using Pizzaria.Domain.Services;
using Pizzaria.Infra.Data.Data.Context;
using Pizzaria.Infra.Data.Data.Repositories;

namespace Pizzaria.Infra.CrossCutting.IoC
{
    public static class NativeContainer
    {
        public static void Configure(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();       
            services.AddSingleton<ITokenService, TokenService>();
            services.AddDbContext<AutenticacaoContext>();
        }
    }
}