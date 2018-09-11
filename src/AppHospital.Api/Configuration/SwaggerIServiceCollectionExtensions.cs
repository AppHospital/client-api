using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace AppHospital.Api.Configuration
{
    internal static class SwaggerIServiceCollectionExtensions
    {
        public static string Title => "AppHospital Api";
        
        public static string Name => "AppHospital_Api";

        public static IServiceCollection AddSwaggerApi(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddSwaggerGen(config => 
                config.SwaggerDoc(
                    Name,
                    new Info {
                        Title = Title
                        }));

            return servicesCollection;
        }
    }
}
