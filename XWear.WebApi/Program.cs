using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Reflection;
using XWear.Application;
using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Infrastructure;
using XWear.WebApi.Common.Errors;
using XWear.WebApi.Configurations.Localization;
using XWear.WebApi.Configurations.Swagger;

namespace XWear.WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services
            .AddApplication()
            .AddInfrastructure(builder.Configuration);

        builder.Services.AddAuthorization();
        builder.Services.AddControllers();
        builder.Services.AddSingleton<ProblemDetailsFactory, XWearErrorProblemDitailsFactory>();
        builder.Services
            .AddCustomSwaggerGen("v1", Assembly.GetExecutingAssembly())
            .AddCustomLocalization(LanguagesEnum.En.GetDescription(), LanguagesEnum.Ru.GetDescription());

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseExceptionHandler("/error");
        app.MapControllers();
        app.UseHttpsRedirection();
        app.UseAuthorization()
           .UseCustomLocalization();
        app.Run();
    }
}