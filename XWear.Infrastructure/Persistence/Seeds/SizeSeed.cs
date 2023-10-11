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
            Size.Create(SizeEnum.S.GetDescription()).Value,
            Size.Create(SizeEnum.M.GetDescription()).Value,
            Size.Create(SizeEnum.L.GetDescription()).Value,
            Size.Create(SizeEnum.Xl.GetDescription()).Value,
            Size.Create(SizeEnum.Xxl.GetDescription()).Value,
            Size.Create(SizeEnum.Xxxl.GetDescription()).Value,
            Size.Create(SizeEnum.ThirtyEight.GetDescription()).Value,
            Size.Create(SizeEnum.ThirtyNine.GetDescription()).Value,
            Size.Create(SizeEnum.Forty.GetDescription()).Value,
            Size.Create(SizeEnum.FortyOne.GetDescription()).Value,
            Size.Create(SizeEnum.FortyTwo.GetDescription()).Value,
            Size.Create(SizeEnum.FortyThree.GetDescription()).Value,
            Size.Create(SizeEnum.FortyFour.GetDescription()).Value,
            Size.Create(SizeEnum.FortyFive.GetDescription()).Value
        };
    
        return sizes;
    }
}
