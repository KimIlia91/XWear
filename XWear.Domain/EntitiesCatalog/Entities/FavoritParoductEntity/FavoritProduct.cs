using XWear.Domain.Catalog.Entities.FavoritParoductEntity.ValueObjects;
using XWear.Domain.Catalog.Entities.ProductEntity.ValueObjects;
using XWear.Domain.Catalog.Entities.UserEntity.ValueObjects;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.Entities.FavoritParoductEntity;

public class FavoritProduct : Entity<FavoriteProductId>
{
    public UserId UserId { get; private set; }

    public ProductId ProductId { get; private set; }

    public DateTime CreatedDateTime { get; private set; }

    public DateTime UpdatedDateTime { get; private set; }

    internal FavoritProduct(
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
