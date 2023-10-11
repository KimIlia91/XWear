using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities.SizeEntity;

namespace XWear.Infrastructure.Persistence.Seeds;

public static class SizeSeed
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        if (!context.Sizes.Any())
        {
            var sizes = CreateSizes();
            await context.Sizes.AddRangeAsync(sizes);
            await context.SaveChangesAsync();
        }
    }

    private static List<Size> CreateSizes()
    {
        var sizes = new List<Size>()
        {
            Size.Create(SizeEnum.S.GetDescription()),
            Size.Create(SizeEnum.M.GetDescription()),
            Size.Create(SizeEnum.L.GetDescription()),
            Size.Create(SizeEnum.Xl.GetDescription()),
            Size.Create(SizeEnum.Xxl.GetDescription()),
            Size.Create(SizeEnum.Xxxl.GetDescription()),
            Size.Create(SizeEnum.ThirtyEight.GetDescription()),
            Size.Create(SizeEnum.ThirtyNine.GetDescription()),
            Size.Create(SizeEnum.Forty.GetDescription()),
            Size.Create(SizeEnum.FortyOne.GetDescription()),
            Size.Create(SizeEnum.FortyTwo.GetDescription()),
            Size.Create(SizeEnum.FortyThree.GetDescription()),
            Size.Create(SizeEnum.FortyFour.GetDescription()),
            Size.Create(SizeEnum.FortyFive.GetDescription())
        };
    
        return sizes;
    }
}
