using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities.ModelEntity;

namespace XWear.Infrastructure.Persistence.Seeds;

public static class ModelSeed
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        if (!context.Models.Any())
        {
            var models = CreateModels();
            await context.Models.AddRangeAsync(models);
            await context.SaveChangesAsync();
        }
    }

    public static List<Model> CreateModels()
    {
        var models = new List<Model>()
        {
            Model.Create(string.Join(" ", CategoryEnum.Activewear.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Bottoms.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Belts.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Dresses.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.FlipFlops.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Gloves.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Gumshoes.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Outerwear.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Swimwear.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Sneakers.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Sandals.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Sleepwear.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Sunglasses.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Scarves.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Shoes.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Handbags.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Hats.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Loafers.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Ties.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Jewelry.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Watches.GetDescription(), nameof(Model))).Value,
            Model.Create(string.Join(" ", CategoryEnum.Wallets.GetDescription(), nameof(Model))).Value
        };
    
        return models;
    }
}
