using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Pizzaria.Core.API.Validation;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Pizzaria.Core.API.Startup
{
    public static class ValidationExtension
    {
        public static IServiceCollection AddValidation(
            this IServiceCollection services,
            Assembly assembly,
            ServiceLifetime lifetime = ServiceLifetime.Transient,
            Func<AssemblyScanner.AssemblyScanResult, bool> filter = null
            )
        {
            services.Add(new ServiceDescriptor(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>), lifetime));
            services.AddValidatorsFromAssembly(assembly, lifetime, filter); 

            return services;
        }
    }
}
