using XWear.Domain.Catalog.ValueObjects;
using XWear.Domain.Common.Models;
using XWear.Domain.FavoritProduct.ValueObjects;

namespace XWear.Domain.Catalog.Entities;

public class FavoriteProduct : Entity<FavoriteProductId>
{
    public UserId UserId { get; private set; }

    public ProductId ProductId { get; private set;   }

    public DateTime CreatedDateTime { get; private set; }

    public DateTime UpdatedDateTime { get; private set; }

    internal FavoriteProduct(
        UserId userId,
        ProductId productId)
        : base(FavoriteProductId.CreateUnique())
    {
        ProductId = productId;
        UserId = userId;
        CreatedDateTime = DateTime.UtcNow;
        UpdatedDateTime = DateTime.UtcNow;
    }
}
