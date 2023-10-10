using XWear.Domain.Common.Models;
using XWear.Domain.Entities.UserEntity.ValueObjects;
using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Domain.Entities.FavoritParoductEntity.ValueObjects;

namespace XWear.Domain.Entities.FavoritParoductEntity;

public class FavoritProduct : AggregateRoot<FavoriteProductId>
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
