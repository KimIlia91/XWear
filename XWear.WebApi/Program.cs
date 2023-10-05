using XWear.Application;
using XWear.Infrastructure;
using XWear.WebApi.Common.Extensions;

namespace XWear.WebApi;

/// <summary>
/// Главный класс приложения.
/// </summary>
public class Program
{
    /// <summary>
    /// Главный метод приложения.
    /// </summary>
    /// <param name="args">Массив аргументов командной строки.</param>
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddPresentation\(builder.Configuration);
        builder.Services.AddApplication();
        builder.Services.AddInfrastructure(builder.Configuration);
        var app = builder.Build();

        app.UseCustomConfiguration();
        app.Run();
    }
}