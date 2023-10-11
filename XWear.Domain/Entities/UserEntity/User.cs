using ErrorOr;
using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.UserEntity.ValueObjects;

namespace XWear.Domain.Entities.UserEntity;

public class User : Entity<UserId>
{
    private readonly List<Product> _favoriteProducts = new();

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string Email { get; private set; }

    public string Phone { get; private set; }

    public string Password { get; private set; }

    public IReadOnlyCollection<Product> FavoritProducts => _favoriteProducts.AsReadOnly();

    private User() : base(UserId.CreateUnique())
    {
    }

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

    public static ErrorOr<User> Create(
        string firstName,
        string lastName,
        string email,
        string phone,
        string password)
    {
        return new User(
            UserId.CreateUnique(),
            firstName,
            lastName,
            email,
            phone,
            password);
    }

    public void AddFavoriteProduct(Product product)
    {
        _favoriteProducts.Add(product);
    }
}
