using XWear.Domain.Common.Models;
using XWear.Domain.Entities.FavoritParoductEntity;
using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Domain.Entities.UserEntity.ValueObjects;

namespace XWear.Domain.Entities.UserEntity;

public class User : Entity<UserId>
{
    private readonly List<FavoritProduct> _favoriteProducts = new();

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string Email { get; private set; }

    public string Phone { get; private set; }

    public string Password { get; private set; }

    public IReadOnlyList<FavoritProduct> FavoriteProducts => _favoriteProducts.AsReadOnly();

    internal User(
        UserId userId,
        string firstName,
        string lastName,
        string email,
        string phone,
        string password)
        : base(userId)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Password = password;
    }

    public static User Create(
        string firstName,
        string lastName,
        string email,
        string phone,
        string password)
    {
        return new(
            UserId.CreateUnique(),
            firstName,
            lastName,
            email,
            phone,
            password);
    }

    public void AddFavoriteProduct(ProductId productId)
    {
        var favoriteProduct = new FavoritProduct(Id, productId);
        _favoriteProducts.Add(favoriteProduct);
    }
}
