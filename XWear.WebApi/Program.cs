using XWear.Application;
using XWear.Infrastructure;
using XWear.Infrastructure.Persistence;

namespace XWear.WebApi;

/// <summary>
/// ������� ����� ����������.
/// </summary>
public class Program
{
    /// <summary>
    /// ������� ����� ����������.
    /// </summary>
    /// <param name="args">������ ���������� ��������� ������.</param>
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddPresentation(builder.Configuration);
        builder.Services.AddApplication();
        builder.Services.AddInfrastructure(builder.Configuration);
        var app = builder.Build();
        app.UsePresentation();

        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;
        await DataBaseSeeds.AddSeeds(services);

        app.Run();
    }
}