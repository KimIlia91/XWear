using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;

namespace XWear.Infrastructure.Persistence.Seeds;

public static class SizeSeed
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        //if (!context.Sizes.Any())
        //{
        //    //var sizes = CreateSizes();
        //    //await context.Sizes.AddRangeAsync(sizes);
        //    //await context.SaveChangesAsync();
        //}
    }

    //private static List<Size> CreateSizes()
    //{
    //    var sizes = new List<Size>()
    //    {
    //        new Size { Name = SizeEnum.S.GetDescription() },
    //        new Size { Name = SizeEnum.M.GetDescription() },
    //        new Size { Name = SizeEnum.L.GetDescription() },
    //        new Size { Name = SizeEnum.Xl.GetDescription() },
    //        new Size { Name = SizeEnum.Xxl.GetDescription() },
    //        new Size { Name = SizeEnum.Xxxl.GetDescription() },
    //        new Size { Name = SizeEnum.ThirtyEight.GetDescription() },
    //        new Size { Name = SizeEnum.ThirtyNine.GetDescription() },
    //        new Size { Name = SizeEnum.Forty.GetDescription() },
    //        new Size { Name = SizeEnum.FortyOne.GetDescription() },
    //        new Size { Name = SizeEnum.FortyTwo.GetDescription() },
    //        new Size { Name = SizeEnum.FortyThree.GetDescription() },
    //        new Size { Name = SizeEnum.FortyFour.GetDescription() },
    //        new Size { Name = SizeEnum.FortyFive.GetDescription() },
    //    };
    //
    //    return sizes;
    //}
}
