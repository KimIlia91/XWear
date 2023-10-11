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
            Brand.Create(BrandEnum.Gucci.GetDescription()).Value,
            Brand.Create(BrandEnum.Timberland.GetDescription()).Value,
            Brand.Create(BrandEnum.Nike.GetDescription()).Value,
            Brand.Create(BrandEnum.Adidas.GetDescription()).Value,
            Brand.Create(BrandEnum.Puma.GetDescription()).Value,
            Brand.Create(BrandEnum.Geox.GetDescription()).Value,
            Brand.Create(BrandEnum.Balenciaga.GetDescription()).Value,
            Brand.Create(BrandEnum.Prada.GetDescription()).Value,
            Brand.Create(BrandEnum.LouisVuitton.GetDescription()).Value,
            Brand.Create(BrandEnum.Dior.GetDescription()).Value,
            Brand.Create(BrandEnum.Versace.GetDescription()).Value,
            Brand.Create(BrandEnum.NewBalance.GetDescription()).Value,
            Brand.Create(BrandEnum.Reebok.GetDescription()).Value,
            Brand.Create(BrandEnum.UnderArmour.GetDescription()).Value,
            Brand.Create(BrandEnum.Saucony.GetDescription()).Value,
            Brand.Create(BrandEnum.Asics.GetDescription()).Value,
            Brand.Create(BrandEnum.Mizuno.GetDescription()).Value,
            Brand.Create(BrandEnum.Vans.GetDescription()).Value,
            Brand.Create(BrandEnum.Chanel.GetDescription()).Value,
            Brand.Create(BrandEnum.Burberry.GetDescription()).Value,
            Brand.Create(BrandEnum.Valentino.GetDescription()).Value
        };
    }
}
