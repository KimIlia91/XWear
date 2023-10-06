using XWear.Domain.Entities;

namespace XWear.Infrastructure.Persistence.Seeds;

public static class ProductSizeSeedGenerator
{
    public static ProductSize Seed()
    {
        var random = new Random();
        decimal minValue = 1.00m;
        decimal maxValue = 1000.00m;
        decimal randomValue = (decimal)random.NextDouble() * (maxValue - minValue) + minValue;

        var productSize = new ProductSize
        {
            Quantity = 10,
            Price = Math.Round(randomValue, 2)
        };

        return productSize;
    }
}
