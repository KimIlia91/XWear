using Microsoft.OpenApi.Models;
using System.Reflection;

namespace XWear.WebApi.Configurations.Swagger
{
    public static class SwaggerSettings
    {
        public static IServiceCollection AddCustomSwaggerGen(
            this IServiceCollection services,
            string name, 
            Assembly executingAssembly)
        {
            services.AddRouting(options => options.LowercaseUrls = true);

            return services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(name, new OpenApiInfo { Title = "High technology park Api", Version = "v1" });
                c.DescribeAllParametersInCamelCase();
                c.OperationFilter<AcceptLanguageHeaderParameter>();

                var xmlFile = $"{executingAssembly.GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath, true);

                var referencedAssembliesNames = executingAssembly.GetReferencedAssemblies().Distinct();
                foreach (var assemblyName in referencedAssembliesNames)
                {
                    var relatedXmlFile = $"{assemblyName.Name}.xml";
                    var relatedXmlPath = Path.Combine(AppContext.BaseDirectory, relatedXmlFile);
                    if (File.Exists(relatedXmlPath))
                    {
                        c.IncludeXmlComments(relatedXmlPath, true);
                    }
                };
            });
        }
    }
}