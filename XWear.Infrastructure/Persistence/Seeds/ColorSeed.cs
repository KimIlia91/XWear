using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities;

namespace XWear.Infrastructure.Persistence.Seeds;

public static class ColorSeed
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        if (!context.Colors.Any())
        {
            //var colors = CreateColors();
            //await context.Colors.AddRangeAsync(colors);
            //await context.SaveChangesAsync();
        }
    }

    //public static List<Color> CreateColors()
    //{
    //    var colors = new List<Color>()
    //    {
    //        new Color { Name = ColorEnum.Red.GetDescription(), Value = ColorEnum.Red },
    //        new Color { Name = ColorEnum.Blue.GetDescription(), Value = ColorEnum.Blue },
    //        new Color { Name = ColorEnum.Pink.GetDescription(), Value = ColorEnum.Pink },
    //        new Color { Name = ColorEnum.Black.GetDescription(), Value = ColorEnum.Black },
    //        new Color { Name = ColorEnum.White.GetDescription(), Value = ColorEnum.White },
    //        new Color { Name = ColorEnum.Yellow.GetDescription(), Value = ColorEnum.Yellow },
    //        new Color { Name = ColorEnum.Violet.GetDescription(), Value = ColorEnum.Violet },
    //        new Color { Name = ColorEnum.Gray.GetDescription(), Value = ColorEnum.Gray },
    //        new Color { Name = ColorEnum.Green.GetDescription(), Value = ColorEnum.Green },
    //        new Color { Name = ColorEnum.Orange.GetDescription(), Value = ColorEnum.Orange },
    //        new Color { Name = ColorEnum.Brown.GetDescription(), Value = ColorEnum.Brown },
    //        new Color { Name = ColorEnum.Beige.GetDescription(), Value = ColorEnum.Beige }
    //    };
    //
    //    return colors;
    //}
}
