using XWear.Application;
using XWear.Infrastructure;

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
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddPresentation(builder.Configuration);
        builder.Services.AddApplication();
        builder.Services.AddInfrastructure(builder.Configuration);
        var app = builder.Build();
        app.UsePresentation();
        app.Run();
    }
}