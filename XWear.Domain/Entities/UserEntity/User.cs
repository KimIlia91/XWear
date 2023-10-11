using ErrorOr;
using XWear.Domain.Common.Models;
using XWear.Domain.Entities.FavoritParoductEntity;
using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Domain.Entities.UserEntity.ValueObjects;

namespace XWear.Domain.Entities.UserEntity;

public class User : Entity<UserId>
{
    private readonly List<FavoritProduct> _favoriteProducts = new();

    public FirstName FirstName { get; private set; }

    public LastName LastName { get; private set; }

    public Email Email { get; private set; }

    public Phone Phone { get; private set; }

    public Password Password { get; private set; }

    public IReadOnlyCollection<FavoritProduct> FavoriteProducts => _favoriteProducts.AsReadOnly();

    internal User(
        UserId userId,
        FirstName firstName,
        LastName lastName,
        Email email,
        Phone phone,
        Password password)
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
        var firstNameResult = FirstName.Create(firstName);

        if (firstNameResult.IsError)
            return firstNameResult.Errors;

        var lastNameResult = LastName.Create(lastName);

        if (lastNameResult.IsError)
            return lastNameResult.Errors;

        var emailResult = Email.Create(email);

        if (emailResult.IsError)
            return emailResult.Errors;

        var passwordResult = Password.Create(password);

        if (passwordResult.IsError)
            return passwordResult.Errors;

        var phoneResult = Phone.Create(phone);  

        if (phoneResult.IsError)
            return phoneResult.Errors;

        return new User(
            UserId.CreateUnique(),
            firstNameResult.Value,
            lastNameResult.Value,
            emailResult.Value,
            phoneResult.Value,
            passwordResult.Value);
    }

    public void AddFavoriteProduct(ProductId productId)
    {
        var favoriteProduct = new FavoritProduct(Id, productId);
        _favoriteProducts.Add(favoriteProduct);
    }
}
