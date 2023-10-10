using XWear.Domain.Catalog.ValueObjects;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.Entities;

public class User : Entity<UserId>
{
    private readonly List<FavoriteProduct> _favoriteProducts = new();

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string Email { get; private set; }

    public string Phone { get; private set; }

    public string Password { get; private set; }

    public IReadOnlyList<FavoriteProduct> FavoriteProducts => _favoriteProducts.AsReadOnly();

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

    public void AddFavoriteProduct(UserId userId, ProductId productId)
    {
        var favoriteProduct = new FavoriteProduct(userId, productId);
        _favoriteProducts.Add(favoriteProduct);
    }
}
