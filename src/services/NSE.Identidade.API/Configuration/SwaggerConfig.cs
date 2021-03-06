using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSE.Identidade.API.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {

                    Title = "NerdStore Enterprize Identity API",
                    Description = "Esta API faz parte do curso ASP.NET Core Enterprise Applications",
                    Contact = new OpenApiContact() { Name = "Pedro Belfort", Email = "pedroamericocostabelfort@gmail.com" },
                    License = new OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensourse.org/licenses/MIT") }
                });
            });

            return services;
        }

        public static IApplicationBuilder UserSwaggerConfiguration(this IApplicationBuilder app)
        {

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

            return app;

            

        }
    }
}
