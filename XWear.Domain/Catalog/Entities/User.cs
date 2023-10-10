using XWear.Domain.Catalog.ValueObjects;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.Entities;

public class User : Entity<UserId>
{
    private readonly List<FavoriteProduct> _favoriteProducts = new();

    public string UserName { get; private set; }

    public IReadOnlyList<FavoriteProduct> FavoriteProducts => _favoriteProducts.AsReadOnly();

    public User(UserId userId, string userName) : base(userId)
    {
        UserName = userName;
    }

    public void AddFavoriteProduct(UserId userId, ProductId productId)
    {
        var favoriteProduct = new FavoriteProduct(userId, productId);
        _favoriteProducts.Add(favoriteProduct);
    }
}
