using Mapster;
using MediatR;
using MapsterMapper;
using FluentValidation;
using System.Reflection;
using XWear.Application.Common.Behaviors;
using Microsoft.Extensions.DependencyInjection;

namespace XWear.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(assembly);
        services.AddSingleton(config);
        services.AddScoped<IMapper, ServiceMapper>();
        services.AddValidatorsFromAssembly(assembly);
        services.AddMediatR(cfg => {
            cfg.RegisterServicesFromAssembly(assembly);
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        });

        return services;
    }
}
