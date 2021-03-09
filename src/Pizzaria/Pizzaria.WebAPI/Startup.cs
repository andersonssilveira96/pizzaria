using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Pizzaria.Core.API.Startup;
using Pizzaria.Infra.CrossCutting.IoC;
using System;
using System.Text;


namespace Pizzaria.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                                    .AllowAnyMethod()
                                    .AllowAnyHeader()
                );
            });

            services.Configure();

            services.AddControllers();            

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Pizzaria.WebAPI", Version = "v1" });
            });

            var assembly = AppDomain.CurrentDomain.Load("Pizzaria.Domain");
            services.AddMediatR(assembly);
            
            // TODO
            // services.AddValidation(assembly);

            var key = Encoding.ASCII.GetBytes(Configuration["Secret"]);
            services.ConfigureAuthentication(key);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();               
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pizzaria.WebAPI v1"));

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("CorsPolicy");
            app.UseAuthentication();
            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
