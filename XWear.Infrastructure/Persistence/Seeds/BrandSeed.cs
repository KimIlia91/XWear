using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;

namespace XWear.Infrastructure.Persistence.Seedsl;

public class BrandSeed
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {

        //if (!context.Brands.Any())
        //{
        //    var years = CreateBrands();
        //    await context.Brands.AddRangeAsync(years);
        //    await context.SaveChangesAsync();
        //}
    }

    //private static List<Brand> CreateBrands()
    //{
    //    return new List<Brand>()
    //    {
    //        new Brand { Name = BrandEnum.Gucci.GetDescription() },
    //        new Brand { Name = BrandEnum.Timberland.GetDescription() },
    //        new Brand { Name = BrandEnum.Nike.GetDescription() },
    //        new Brand { Name = BrandEnum.Adidas.GetDescription() },
    //        new Brand { Name = BrandEnum.Puma.GetDescription() },
    //        new Brand { Name = BrandEnum.Geox.GetDescription() },
    //        new Brand { Name = BrandEnum.Balenciaga.GetDescription() },
    //        new Brand { Name = BrandEnum.Prada.GetDescription() },
    //        new Brand { Name = BrandEnum.LouisVuitton.GetDescription() },
    //        new Brand { Name = BrandEnum.Dior.GetDescription() },
    //        new Brand { Name = BrandEnum.Versace.GetDescription() },
    //        new Brand { Name = BrandEnum.NewBalance.GetDescription() },
    //        new Brand { Name = BrandEnum.Reebok.GetDescription() },
    //        new Brand { Name = BrandEnum.UnderArmour.GetDescription() },
    //        new Brand { Name = BrandEnum.Saucony.GetDescription() },
    //        new Brand { Name = BrandEnum.Asics.GetDescription() },
    //        new Brand { Name = BrandEnum.Mizuno.GetDescription() },
    //        new Brand { Name = BrandEnum.Vans.GetDescription() },
    //        new Brand { Name = BrandEnum.Chanel.GetDescription() },
    //        new Brand { Name = BrandEnum.Burberry.GetDescription() },
    //        new Brand { Name = BrandEnum.Valentino.GetDescription() }
    //    };
    //}
}
