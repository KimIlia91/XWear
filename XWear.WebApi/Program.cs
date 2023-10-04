using XWear.WebApi.Common.Extensions;

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

        builder.Services.AddCustomServices(builder.Configuration);

        var app = builder.Build();

        app.UseCustomConfiguration();
        app.Run();
    }
}