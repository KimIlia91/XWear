using XWear.Domain.Entities;
using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using Microsoft.EntityFrameworkCore;

namespace XWear.Infrastructure.Persistence.Seeds;

public static class ProductSeed
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        if (!await context.Products.AnyAsync())
        {
            var products = await CreateProductsAsync(context);
            await context.Products.AddRangeAsync(products);
            await context.SaveChangesAsync();
        }
    }

    public static async Task<List<Product>> CreateProductsAsync(ApplicationDbContext context)
    {
        var categories = await context.Categories.ToListAsync();

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

        var brands = await context.Brands.ToListAsync();

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

        var colors = await context.Colors.ToListAsync();

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

        var sizes = await context.Sizes.ToListAsync();

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

        var models = await context.Models.ToListAsync();

        var activewearModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Activewear.GetDescription(), nameof(Model)));
        var bottomsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Bottoms.GetDescription(), nameof(Model)));
        var beltsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Belts.GetDescription(), nameof(Model)));
        var dressesModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Dresses.GetDescription(), nameof(Model)));
        var flipFlopsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.FlipFlops.GetDescription(), nameof(Model)));
        var glovesModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Gloves.GetDescription(), nameof(Model)));
        var gumshoesModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Gumshoes.GetDescription(), nameof(Model)));
        var outerwearModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Outerwear.GetDescription(), nameof(Model)));
        var swimwearModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Swimwear.GetDescription(), nameof(Model)));
        var sneakersModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Sneakers.GetDescription(), nameof(Model)));
        var sandalsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Sandals.GetDescription(), nameof(Model)));
        var sleepwearModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Sleepwear.GetDescription(), nameof(Model)));
        var sunglassesModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Sunglasses.GetDescription(), nameof(Model)));
        var scarvesModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Scarves.GetDescription(), nameof(Model)));
        var handbagsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Handbags.GetDescription(), nameof(Model)));
        var hatsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Hats.GetDescription(), nameof(Model)));
        var loafersModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Loafers.GetDescription(), nameof(Model)));
        var lingerieModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Lingerie.GetDescription(), nameof(Model)));
        var topsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Tops.GetDescription(), nameof(Model)));
        var tiesModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Ties.GetDescription(), nameof(Model)));
        var jewelryModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Jewelry.GetDescription(), nameof(Model)));
        var watchesModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Watches.GetDescription(), nameof(Model)));
        var walletsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Wallets.GetDescription(), nameof(Model)));

        var products = new List<Product>()
        {
            new Product
            {
                ImgUrl = "URL1",
                ModelId = activewearModel.Id,
                SizeId = Xl.Id,
                CategoryId = activewear.Id,
                BrandId = adidas.Id,
                ColorId = red.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL2",
                ModelId = activewearModel.Id,
                SizeId = Xxl.Id,
                CategoryId = activewear.Id,
                BrandId = adidas.Id,
                ColorId = red.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL3",
                ModelId = activewearModel.Id,
                SizeId = S.Id,
                CategoryId = activewear.Id,
                BrandId = gucci.Id,
                ColorId = red.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL4",
                ModelId = activewearModel.Id,
                SizeId = L.Id,
                CategoryId = activewear.Id,
                BrandId = gucci.Id,
                ColorId = red.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL5",
                ModelId = activewearModel.Id,
                SizeId = M.Id,
                CategoryId = activewear.Id,
                BrandId = gucci.Id,
                ColorId = red.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL6",
                ModelId = activewearModel.Id,
                SizeId = Xxl.Id,
                CategoryId = activewear.Id,
                BrandId = gucci.Id,
                ColorId = blue.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL7",
                ModelId = activewearModel.Id,
                SizeId = Xl.Id,
                CategoryId = activewear.Id,
                BrandId = gucci.Id,
                ColorId = blue.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL8",
                ModelId = activewearModel.Id,
                SizeId = L.Id,
                CategoryId = activewear.Id,
                BrandId = gucci.Id,
                ColorId = blue.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL9",
                ModelId = activewearModel.Id,
                SizeId = M.Id,
                CategoryId = activewear.Id,
                BrandId = gucci.Id,
                ColorId = blue.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL10",
                ModelId = activewearModel.Id,
                SizeId = S.Id,
                CategoryId = activewear.Id,
                BrandId = gucci.Id,
                ColorId = yellow.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL11",
                ModelId = activewearModel.Id,
                SizeId = M.Id,
                CategoryId = activewear.Id,
                BrandId = gucci.Id,
                ColorId = yellow.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL12",
                ModelId = activewearModel.Id,
                SizeId = L.Id,
                CategoryId = activewear.Id,
                BrandId = gucci.Id,
                ColorId = yellow.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL13",
                ModelId = activewearModel.Id,
                SizeId = Xl.Id,
                CategoryId = activewear.Id,
                BrandId = gucci.Id,
                ColorId = yellow.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL14",
                ModelId = activewearModel.Id,
                SizeId = Xxl.Id,
                CategoryId = activewear.Id,
                BrandId = gucci.Id,
                ColorId = yellow.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL15",
                ModelId = activewearModel.Id,
                SizeId = Xxxl.Id,
                CategoryId = activewear.Id,
                BrandId = gucci.Id,
                ColorId = yellow.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL16",
                ModelId = bottomsModel.Id,
                SizeId = Xxxl.Id,
                CategoryId = bottoms.Id,
                BrandId = louisVuitton.Id,
                ColorId = yellow.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL17",
                ModelId = bottomsModel.Id,
                SizeId = Xxl.Id,
                CategoryId = bottoms.Id,
                BrandId = louisVuitton.Id,
                ColorId = yellow.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL18",
                ModelId = bottomsModel.Id,
                SizeId = Xl.Id,
                CategoryId = bottoms.Id,
                BrandId = louisVuitton.Id,
                ColorId = yellow.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL19",
                ModelId = bottomsModel.Id,
                SizeId = L.Id,
                CategoryId = bottoms.Id,
                BrandId = louisVuitton.Id,
                ColorId = yellow.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL20",
                ModelId = bottomsModel.Id,
                SizeId = M.Id,
                CategoryId = bottoms.Id,
                BrandId = louisVuitton.Id,
                ColorId = yellow.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL21",
                ModelId = bottomsModel.Id,
                SizeId = S.Id,
                CategoryId = bottoms.Id,
                BrandId = louisVuitton.Id,
                ColorId = yellow.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL22",
                ModelId = bottomsModel.Id,
                SizeId = S.Id,
                CategoryId = bottoms.Id,
                BrandId = louisVuitton.Id,
                ColorId = red.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL23",
                ModelId = bottomsModel.Id,
                SizeId = M.Id,
                CategoryId = bottoms.Id,
                BrandId = louisVuitton.Id,
                ColorId = red.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL24",
                ModelId = bottomsModel.Id,
                SizeId = M.Id,
                CategoryId = bottoms.Id,
                BrandId = louisVuitton.Id,
                ColorId = red.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL25",
                ModelId = bottomsModel.Id,
                SizeId = L.Id,
                CategoryId = bottoms.Id,
                BrandId = louisVuitton.Id,
                ColorId = red.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL26",
                ModelId = bottomsModel.Id,
                SizeId = Xxl.Id,
                CategoryId = bottoms.Id,
                BrandId = louisVuitton.Id,
                ColorId = red.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL27",
                ModelId = bottomsModel.Id,
                SizeId = Xxxl.Id,
                CategoryId = bottoms.Id,
                BrandId = louisVuitton.Id,
                ColorId = red.Id,
                Quantity = 10,
                Price = 99.99m
            },
            new Product
            {
                ImgUrl = "URL27",
                ModelId = beltsModel.Id,
                SizeId = Xxxl.Id,
                CategoryId = belts.Id,
                BrandId = versace.Id,
                ColorId = white.Id,
                Quantity = 10,
                Price = 99.99m
            },
        };

        return products;
    }
}
