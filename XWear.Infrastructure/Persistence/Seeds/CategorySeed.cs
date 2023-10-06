using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities;

namespace XWear.Infrastructure.Persistence.Seeds
{
    public static class CategorySeed
    {
        public static List<Category> Seed()
        {
            var categories = new List<Category>()
            {
                new Category{ Name = CategoryEnum.Activewear.GetDescription() },

                new Category{ Name = CategoryEnum.Belts.GetDescription() },
                new Category{ Name = CategoryEnum.Bottoms.GetDescription() },

                new Category{ Name = CategoryEnum.Dresses.GetDescription() },

                new Category{ Name = CategoryEnum.FlipFlops.GetDescription() },

                new Category{ Name = CategoryEnum.Gloves.GetDescription() },
                new Category{ Name = CategoryEnum.Gumshoes.GetDescription() },

                new Category{ Name = CategoryEnum.Outerwear.GetDescription() },

                new Category{ Name = CategoryEnum.Scarves.GetDescription() },
                new Category{ Name = CategoryEnum.Sandals.GetDescription() },
                new Category{ Name = CategoryEnum.Swimwear.GetDescription() },
                new Category{ Name = CategoryEnum.Sunglasses.GetDescription() },
                new Category{ Name = CategoryEnum.Sneakers.GetDescription() },
                new Category{ Name = CategoryEnum.Sleepwear.GetDescription() },

                new Category{ Name = CategoryEnum.Handbags.GetDescription() },
                new Category{ Name = CategoryEnum.Hats.GetDescription() },

                new Category{ Name = CategoryEnum.Loafers.GetDescription() },
                new Category{ Name = CategoryEnum.Lingerie.GetDescription() },

                new Category{ Name = CategoryEnum.Ties.GetDescription() },
                new Category{ Name = CategoryEnum.Tops.GetDescription() },

                new Category{ Name = CategoryEnum.Jewelry.GetDescription() },
  
                new Category{ Name = CategoryEnum.Wallets.GetDescription() },
                new Category{ Name = CategoryEnum.Watches.GetDescription() }
            };

            return categories;
        }
    }
}
