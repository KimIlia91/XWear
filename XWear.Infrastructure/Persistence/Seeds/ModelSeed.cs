using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities;

namespace XWear.Infrastructure.Persistence.Seeds
{
    public static class ModelSeed
    {
        public static List<Model> Seed()
        {
            var models = new List<Model>()
            {
                new Model { Name = string.Join(" ", CategoryEnum.Activewear.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Bottoms.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Belts.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Dresses.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.FlipFlops.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Gloves.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Gumshoes.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Outerwear.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Swimwear.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Sneakers.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Sandals.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Sleepwear.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Sunglasses.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Scarves.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Handbags.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Hats.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Loafers.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Lingerie.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Tops.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Ties.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Jewelry.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Watches.GetDescription(), nameof(Model)) },
                new Model { Name = string.Join(" ", CategoryEnum.Wallets.GetDescription(), nameof(Model)) }
            };

            return models;
        }
    }
}
