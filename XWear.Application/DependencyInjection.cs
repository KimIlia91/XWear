using MediatR;
using FluentValidation;
using System.Reflection;
using XWear.Application.Common.Behaviors;
using Microsoft.Extensions.DependencyInjection;
using XWear.Application.Common.Mapping;

namespace XWear.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        services.AddMapping(assembly);
        services.AddValidatorsFromAssembly(assembly);
        services.AddMediatR(cfg => {
            cfg.RegisterServicesFromAssembly(assembly);
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        });

        return services;
    }
}
