using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Reflection;
using XWear.Application;
using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Infrastructure;
using XWear.WebApi.Common.Constants;
using XWear.WebApi.Common.Errors;
using XWear.WebApi.Common.Extensions;
using XWear.WebApi.Configurations.CorsConfig;
using XWear.WebApi.Configurations.Localization;
using XWear.WebApi.Configurations.Swagger;

namespace XWear.WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddCustomServices(builder.Configuration);

        var app = builder.Build();

        app.UseCustomConfiguration();
        app.Run();
    }
}