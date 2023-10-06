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

        var models = ModelSeed.Seed();

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
            // Продукт 1
            new Product
            {
                ImgUrl = "URL1",
                ModelId = activewearModel.Id,
                Model = activewearModel,
                CategoryId = activewear.Id,
                Category = activewear,
                BrandId = gucci.Id,
                Brand = gucci,
                ColorId = red.Id,
                Color = red,
            },

            // Продукт 2
            new Product
            {
                ImgUrl = "URL2",
                ModelId = bottomsModel.Id,
                Model = bottomsModel,
                CategoryId = bottoms.Id,
                Category = bottoms,
                BrandId = timberland.Id,
                Brand = timberland,
                ColorId = blue.Id,
                Color = blue,
            },

            // Продукт 3
            new Product
            {
                ImgUrl = "URL3",
                ModelId = beltsModel.Id,
                Model = beltsModel,
                CategoryId = belts.Id,
                Category = belts,
                BrandId = nike.Id,
                Brand = nike,
                ColorId = pink.Id,
                Color = pink,
            },

            // Продукт 4
            new Product
            {
                ImgUrl = "URL4",
                ModelId = dressesModel.Id,
                Model = dressesModel,
                CategoryId = dresses.Id,
                Category = dresses,
                BrandId = adidas.Id,
                Brand = adidas,
                ColorId = black.Id,
                Color = black,
            },

            // Продукт 5
            new Product
            {
                ImgUrl = "URL5",
                ModelId = flipFlopsModel.Id,
                Model = flipFlopsModel,
                CategoryId = flipFlops.Id,
                Category = flipFlops,
                BrandId = puma.Id,
                Brand = puma,
                ColorId = white.Id,
                Color = white,
            },

            // Продукт 6
            new Product
            {
                ImgUrl = "URL6",
                ModelId = glovesModel.Id,
                Model = glovesModel,
                CategoryId = gloves.Id,
                Category = gloves,
                BrandId = geox.Id,
                Brand = geox,
                ColorId = yellow.Id,
                Color = yellow,
            },

            // Продукт 7
            new Product
            {
                ImgUrl = "URL7",
                ModelId = gumshoesModel.Id,
                Model = gumshoesModel,
                CategoryId = gumshoes.Id,
                Category = gumshoes,
                BrandId = balenciaga.Id,
                Brand = balenciaga,
                ColorId = violet.Id,
                Color = violet,
            },

            // Продукт 8
            new Product
            {
                ImgUrl = "URL8",
                ModelId = outerwearModel.Id,
                Model = outerwearModel,
                CategoryId = outerwear.Id,
                Category = outerwear,
                BrandId = prada.Id,
                Brand = prada,
                ColorId = gray.Id,
                Color = gray,
            },

            // Продукт 9
            new Product
            {
                ImgUrl = "URL9",
                ModelId = swimwearModel.Id,
                Model = swimwearModel,
                CategoryId = swimwear.Id,
                Category = swimwear,
                BrandId = louisVuitton.Id,
                Brand = louisVuitton,
                ColorId = green.Id,
                Color = green,
            },

            // Продукт 10
            new Product
            {
                ImgUrl = "URL10",
                ModelId = sneakersModel.Id,
                Model = sneakersModel,
                CategoryId = sneakers.Id,
                Category = sneakers,
                BrandId = dior.Id,
                Brand = dior,
                ColorId = orange.Id,
                Color = orange,
            },

            // Продукт 11
            new Product
            {
                ImgUrl = "URL11",
                ModelId = sandalsModel.Id,
                Model = sandalsModel,
                CategoryId = sandals.Id,
                Category = sandals,
                BrandId = versace.Id,
                Brand = versace,
                ColorId = brown.Id,
                Color = brown,
            },

            // Продукт 12
            new Product
            {
                ImgUrl = "URL12",
                ModelId = sleepwearModel.Id,
                Model = sleepwearModel,
                CategoryId = sleepwear.Id,
                Category = sleepwear,
                BrandId = newBalance.Id,
                Brand = newBalance,
                ColorId = beige.Id,
                Color = beige,
            },

            // Продукт 13
            new Product
            {
                ImgUrl = "URL13",
                ModelId = sunglassesModel.Id,
                Model = sunglassesModel,
                CategoryId = sunglasses.Id,
                Category = sunglasses,
                BrandId = reebok.Id,
                Brand = reebok,
                ColorId = blue.Id,
                Color = blue,
            },

            // Продукт 14
            new Product
            {
                ImgUrl = "URL14",
                ModelId = scarvesModel.Id,
                Model = scarvesModel,
                CategoryId = scarves.Id,
                Category = scarves,
                BrandId = underArmour.Id,
                Brand = underArmour,
                ColorId = pink.Id,
                Color = pink,
            },

            // Продукт 15
            new Product
            {
                ImgUrl = "URL15",
                ModelId = handbagsModel.Id,
                Model = handbagsModel,
                CategoryId = handbags.Id,
                Category = handbags,
                BrandId = saucony.Id,
                Brand = saucony,
                ColorId = black.Id,
                Color = black,
            },

            // Продукт 16
            new Product
            {
                ImgUrl = "URL16",
                ModelId = hatsModel.Id,
                Model = hatsModel,
                CategoryId = hats.Id,
                Category = hats,
                BrandId = asics.Id,
                Brand = asics,
                ColorId = white.Id,
                Color = white,
            },

            // Продукт 17
            new Product
            {
                ImgUrl = "URL17",
                ModelId = loafersModel.Id,
                Model = loafersModel,
                CategoryId = loafers.Id,
                Category = loafers,
                BrandId = mizuno.Id,
                Brand = mizuno,
                ColorId = violet.Id,
                Color = violet,
            },

            // Продукт 18
            new Product
            {
                ImgUrl = "URL18",
                ModelId = lingerieModel.Id,
                Model = lingerieModel,
                CategoryId = lingerie.Id,
                Category = lingerie,
                BrandId = vans.Id,
                Brand = vans,
                ColorId = gray.Id,
                Color = gray,
            },

            // Продукт 19
            new Product
            {
                ImgUrl = "URL19",
                ModelId = topsModel.Id,
                Model = topsModel,
                CategoryId = tops.Id,
                Category = tops,
                BrandId = chanel.Id,
                Brand = chanel,
                ColorId = red.Id,
                Color = red,
            },

            // Продукт 20
            new Product
            {
                ImgUrl = "URL20",
                ModelId = tiesModel.Id,
                Model = tiesModel,
                CategoryId = ties.Id,
                Category = ties,
                BrandId = burberry.Id,
                Brand = burberry,
                ColorId = blue.Id,
                Color = blue,
            },

            // Продукт 21
            new Product
            {
                ImgUrl = "URL21",
                ModelId = jewelryModel.Id,
                Model = jewelryModel,
                CategoryId = jewelry.Id,
                Category = jewelry,
                BrandId = valentino.Id,
                Brand = valentino,
                ColorId = pink.Id,
                Color = pink,
            },

            // Продукт 22
            new Product
            {
                ImgUrl = "URL22",
                ModelId = watchesModel.Id,
                Model = watchesModel,
                CategoryId = watches.Id,
                Category = watches,
                BrandId = nike.Id,
                Brand = nike,
                ColorId = black.Id,
                Color = black,
            },

            // Продукт 23
            new Product
            {
                ImgUrl = "URL23",
                ModelId = walletsModel.Id,
                Model = walletsModel,
                CategoryId = wallets.Id,
                Category = wallets,
                BrandId = adidas.Id,
                Brand = adidas,
                ColorId = white.Id,
                Color = white,
            },

            // Продукт 24
            new Product
            {
                ImgUrl = "URL24",
                ModelId = activewearModel.Id,
                Model = activewearModel,
                CategoryId = activewear.Id,
                Category = activewear,
                BrandId = gucci.Id,
                Brand = gucci,
                ColorId = yellow.Id,
                Color = yellow,
            },

            // Продукт 25
            new Product
            {
                ImgUrl = "URL25",
                ModelId = bottomsModel.Id,
                Model = bottomsModel,
                CategoryId = bottoms.Id,
                Category = bottoms,
                BrandId = timberland.Id,
                Brand = timberland,
                ColorId = violet.Id,
                Color = violet,
            },

            // Продукт 26
            new Product
            {
                ImgUrl = "URL26",
                ModelId = beltsModel.Id,
                Model = beltsModel,
                CategoryId = belts.Id,
                Category = belts,
                BrandId = nike.Id,
                Brand = nike,
                ColorId = gray.Id,
                Color = gray,
            },

            // Продукт 27
            new Product
            {
                ImgUrl = "URL27",
                ModelId = dressesModel.Id,
                Model = dressesModel,
                CategoryId = dresses.Id,
                Category = dresses,
                BrandId = adidas.Id,
                Brand = adidas,
                ColorId = black.Id,
                Color = black,
            },

            // Продукт 28
            new Product
            {
                ImgUrl = "URL28",
                ModelId = flipFlopsModel.Id,
                Model = flipFlopsModel,
                CategoryId = flipFlops.Id,
                Category = flipFlops,
                BrandId = puma.Id,
                Brand = puma,
                ColorId = white.Id,
                Color = white,
            },

            // Продукт 29
            new Product
            {
                ImgUrl = "URL29",
                ModelId = glovesModel.Id,
                Model = glovesModel,
                CategoryId = gloves.Id,
                Category = gloves,
                BrandId = geox.Id,
                Brand = geox,
                ColorId = yellow.Id,
                Color = yellow,
            },

            // Продукт 30
            new Product
            {
                ImgUrl = "URL30",
                ModelId = gumshoesModel.Id,
                Model = gumshoesModel,
                CategoryId = gumshoes.Id,
                Category = gumshoes,
                BrandId = balenciaga.Id,
                Brand = balenciaga,
                ColorId = violet.Id,
                Color = violet,
            },
        };

        return products;
    }
}
