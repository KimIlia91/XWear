using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities.ColorEntity;

namespace XWear.Infrastructure.Persistence.Seeds;

public static class ColorSeed
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        if (!context.Colors.Any())
        {
            var colors = CreateColors();
            await context.Colors.AddRangeAsync(colors);
            await context.SaveChangesAsync();
        }
    }

    public static List<Color> CreateColors()
    {
        var colors = new List<Color>()
        {
            Color.Create(ColorEnum.Red.GetDescription()).Value,
            Color.Create(ColorEnum.Blue.GetDescription()).Value,
            Color.Create(ColorEnum.Pink.GetDescription()).Value,
            Color.Create(ColorEnum.Black.GetDescription()).Value,
            Color.Create(ColorEnum.White.GetDescription()).Value,
            Color.Create(ColorEnum.Yellow.GetDescription()).Value,
            Color.Create(ColorEnum.Violet.GetDescription()).Value,
            Color.Create(ColorEnum.Gray.GetDescription()).Value,
            Color.Create(ColorEnum.Green.GetDescription()).Value,
            Color.Create(ColorEnum.Orange.GetDescription()).Value,
            Color.Create(ColorEnum.Brown.GetDescription()).Value,
            Color.Create(ColorEnum.Beige.GetDescription()).Value
        };
    
        return colors;
    }
}
