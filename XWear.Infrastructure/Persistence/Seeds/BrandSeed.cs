using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities.BrandEntity;

namespace XWear.Infrastructure.Persistence.Seedsl;

public class BrandSeed
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {

        if (!context.Brands.Any())
        {
            var brands = CreateBrands();
            await context.Brands.AddRangeAsync(brands);
            await context.SaveChangesAsync();
        }
    }

    private static List<Brand> CreateBrands()
    {
        return new List<Brand>()
        {
            Brand.Create(BrandEnum.Gucci.GetDescription()),
            Brand.Create(BrandEnum.Timberland.GetDescription()),
            Brand.Create(BrandEnum.Nike.GetDescription()),
            Brand.Create(BrandEnum.Adidas.GetDescription()),
            Brand.Create(BrandEnum.Puma.GetDescription()),
            Brand.Create(BrandEnum.Geox.GetDescription()),
            Brand.Create(BrandEnum.Balenciaga.GetDescription()),
            Brand.Create(BrandEnum.Prada.GetDescription()),
            Brand.Create(BrandEnum.LouisVuitton.GetDescription()),
            Brand.Create(BrandEnum.Dior.GetDescription()),
            Brand.Create(BrandEnum.Versace.GetDescription()),
            Brand.Create(BrandEnum.NewBalance.GetDescription()),
            Brand.Create(BrandEnum.Reebok.GetDescription()),
            Brand.Create(BrandEnum.UnderArmour.GetDescription()),
            Brand.Create(BrandEnum.Saucony.GetDescription()),
            Brand.Create(BrandEnum.Asics.GetDescription()),
            Brand.Create(BrandEnum.Mizuno.GetDescription()),
            Brand.Create(BrandEnum.Vans.GetDescription()),
            Brand.Create(BrandEnum.Chanel.GetDescription()),
            Brand.Create(BrandEnum.Burberry.GetDescription()),
            Brand.Create(BrandEnum.Valentino.GetDescription())
        };
    }
}
