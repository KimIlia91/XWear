using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities;
using XWear.Infrastructure.Persistence.Seedsl;

namespace XWear.Infrastructure.Persistence.Seeds;

public static class ProductSeed
{
    public static List<Product> Seed()
    {
        var categories = CategorySeed.Seed();

        var activewear = categories.First(c => c.Name == CategoryEnum.Activewear.GetDescription());
        var bottoms = categories.First(c => c.Name == CategoryEnum.Bottoms.GetDescription());
        var belts = categories.First(c => c.Name == CategoryEnum.Belts.GetDescription());
        var dresses = categories.First(c => c.Name == CategoryEnum.Dresses.GetDescription());
        var flipFlops = categories.First(c => c.Name == CategoryEnum.FlipFlops.GetDescription());
        var gloves = categories.First(c => c.Name == CategoryEnum.Gloves.GetDescription());
        var gumshoes = categories.First(c => c.Name == CategoryEnum.Gumshoes.GetDescription());
        var outerwear = categories.First(c => c.Name == CategoryEnum.Outerwear.GetDescription());
        var swimwear = categories.First(c => c.Name == CategoryEnum.Swimwear.GetDescription());
        var sneakers = categories.First(c => c.Name == CategoryEnum.Sneakers.GetDescription());
        var sandals = categories.First(c => c.Name == CategoryEnum.Sandals.GetDescription());
        var sleepwear = categories.First(c => c.Name == CategoryEnum.Sleepwear.GetDescription());
        var sunglasses = categories.First(c => c.Name == CategoryEnum.Sunglasses.GetDescription());
        var scarves = categories.First(c => c.Name == CategoryEnum.Scarves.GetDescription());
        var handbags = categories.First(c => c.Name == CategoryEnum.Handbags.GetDescription());
        var hats = categories.First(c => c.Name == CategoryEnum.Hats.GetDescription());
        var loafers = categories.First(c => c.Name == CategoryEnum.Loafers.GetDescription());
        var lingerie = categories.First(c => c.Name == CategoryEnum.Lingerie.GetDescription());
        var tops = categories.First(c => c.Name == CategoryEnum.Tops.GetDescription());
        var ties = categories.First(c => c.Name == CategoryEnum.Ties.GetDescription());
        var jewelry = categories.First(c => c.Name == CategoryEnum.Jewelry.GetDescription());
        var watches = categories.First(c => c.Name == CategoryEnum.Watches.GetDescription());
        var wallets = categories.First(c => c.Name == CategoryEnum.Wallets.GetDescription());

        var brands = BrandSeed.Seed();

        var gucci = brands.First(c => c.Name == BrandEnum.Gucci.GetDescription());
        var timberland = brands.First(c => c.Name == BrandEnum.Timberland.GetDescription());
        var nike = brands.First(c => c.Name == BrandEnum.Nike.GetDescription());
        var adidas = brands.First(c => c.Name == BrandEnum.Adidas.GetDescription());
        var puma = brands.First(c => c.Name == BrandEnum.Puma.GetDescription());
        var geox = brands.First(c => c.Name == BrandEnum.Geox.GetDescription());
        var balenciaga = brands.First(c => c.Name == BrandEnum.Balenciaga.GetDescription());
        var prada = brands.First(c => c.Name == BrandEnum.Prada.GetDescription());
        var louisVuitton = brands.First(c => c.Name == BrandEnum.LouisVuitton.GetDescription());
        var dior = brands.First(c => c.Name == BrandEnum.Dior.GetDescription());
        var versace = brands.First(c => c.Name == BrandEnum.Versace.GetDescription());
        var newBalance = brands.First(c => c.Name == BrandEnum.NewBalance.GetDescription());
        var reebok = brands.First(c => c.Name == BrandEnum.Reebok.GetDescription());
        var underArmour = brands.First(c => c.Name == BrandEnum.UnderArmour.GetDescription());
        var saucony = brands.First(c => c.Name == BrandEnum.Saucony.GetDescription());
        var asics = brands.First(c => c.Name == BrandEnum.Asics.GetDescription());
        var mizuno = brands.First(c => c.Name == BrandEnum.Mizuno.GetDescription());
        var vans = brands.First(c => c.Name == BrandEnum.Vans.GetDescription());
        var chanel = brands.First(c => c.Name == BrandEnum.Chanel.GetDescription());
        var burberry = brands.First(c => c.Name == BrandEnum.Burberry.GetDescription());
        var valentino = brands.First(c => c.Name == BrandEnum.Valentino.GetDescription());

        var colors = ColorSeed.Seed();

        var red = colors.First(c => c.Value == ColorEnum.Red);
        var blue = colors.First(c => c.Value == ColorEnum.Blue);
        var pink = colors.First(c => c.Value == ColorEnum.Pink);
        var black = colors.First(c => c.Value == ColorEnum.Black);
        var white = colors.First(c => c.Value == ColorEnum.White);
        var yellow = colors.First(c => c.Value == ColorEnum.Yellow);
        var violet = colors.First(c => c.Value == ColorEnum.Violet);
        var gray = colors.First(c => c.Value == ColorEnum.Gray);
        var green = colors.First(c => c.Value == ColorEnum.Green);
        var orange = colors.First(c => c.Value == ColorEnum.Orange);
        var brown = colors.First(c => c.Value == ColorEnum.Brown);
        var beige = colors.First(c => c.Value == ColorEnum.Beige);

        var sizes = SizeSeed.Seed();

        var S = sizes.First(s => s.Name == SizeEnum.S.GetDescription());
        var M = sizes.First(s => s.Name == SizeEnum.M.GetDescription());
        var L = sizes.First(s => s.Name == SizeEnum.L.GetDescription());
        var Xl = sizes.First(s => s.Name == SizeEnum.Xl.GetDescription());
        var Xxl = sizes.First(s => s.Name == SizeEnum.Xxl.GetDescription());
        var Xxxl = sizes.First(s => s.Name == SizeEnum.Xxxl.GetDescription());
        var ThirtyEight = sizes.First(s => s.Name == SizeEnum.ThirtyEight.GetDescription());
        var ThirtyNine = sizes.First(s => s.Name == SizeEnum.ThirtyNine.GetDescription());
        var Forty = sizes.First(s => s.Name == SizeEnum.Forty.GetDescription());
        var FortyOne = sizes.First(s => s.Name == SizeEnum.FortyOne.GetDescription());
        var FortyTwo = sizes.First(s => s.Name == SizeEnum.FortyTwo.GetDescription());
        var FortyThree = sizes.First(s => s.Name == SizeEnum.FortyThree.GetDescription());
        var FortyFour = sizes.First(s => s.Name == SizeEnum.FortyFour.GetDescription());
        var FortyFive = sizes.First(s => s.Name == SizeEnum.FortyFive.GetDescription());

        var products = new List<Product>()
        {

        };

        return products;
    }
}
