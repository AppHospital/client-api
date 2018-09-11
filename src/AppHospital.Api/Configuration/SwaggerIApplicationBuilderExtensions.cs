using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace AppHospital.Api.Configuration
{
    internal static class SawggerIApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSwaggerApi(this IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger();

            if (!env.IsProduction())
            {
                app.UseSwaggerUI(c =>
                {
                    c.DocumentTitle = SwaggerIServiceCollectionExtensions.Title;
                    c.SwaggerEndpoint($"../swagger/{SwaggerIServiceCollectionExtensions.Name}/swagger.json", SwaggerIServiceCollectionExtensions.Title);
                });
            }

            return app;
        }
    }
}