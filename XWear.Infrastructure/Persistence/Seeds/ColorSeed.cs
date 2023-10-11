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
            Color.Create(ColorEnum.Red.GetDescription(), nameof(ColorEnum.Red)),
            Color.Create(ColorEnum.Blue.GetDescription(), nameof(ColorEnum.Blue)),
            Color.Create(ColorEnum.Pink.GetDescription(), nameof(ColorEnum.Pink)),
            Color.Create(ColorEnum.Black.GetDescription(), nameof(ColorEnum.Black)),
            Color.Create(ColorEnum.White.GetDescription(), nameof(ColorEnum.White)),
            Color.Create(ColorEnum.Yellow.GetDescription(), nameof(ColorEnum.Yellow)),
            Color.Create(ColorEnum.Violet.GetDescription(), nameof(ColorEnum.Violet)),
            Color.Create(ColorEnum.Gray.GetDescription(), nameof(ColorEnum.Gray)),
            Color.Create(ColorEnum.Green.GetDescription(), nameof(ColorEnum.Green)),
            Color.Create(ColorEnum.Orange.GetDescription(), nameof(ColorEnum.Orange)),
            Color.Create(ColorEnum.Brown.GetDescription(), nameof(ColorEnum.Brown)),
            Color.Create(ColorEnum.Beige.GetDescription(), nameof(ColorEnum.Beige))
        };
    
        return colors;
    }
}
