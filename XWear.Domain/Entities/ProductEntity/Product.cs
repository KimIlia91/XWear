﻿using ErrorOr;
using XWear.Domain.Common.Models;
using XWear.Domain.Entities.SizeEntity;
using XWear.Domain.Entities.ColorEntity;
using XWear.Domain.Entities.BrandEntity;
using XWear.Domain.Entities.ModelEntity;
using XWear.Domain.Entities.CategoryEntity;
using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Domain.Entities.UserEntity;

namespace XWear.Domain.Entities.ProductEntity;

public sealed class Product : AggregateRoot<ProductId>
{
    private readonly List<User> _favoritByUsers = new();

    public Price Price { get; private set; }

    public Quantity Quantity { get; private set; }

    public ImageUrl ImgUrl { get; private set; } = null!;

    public DateTime CreatedDateTime { get; private set; }

    public DateTime UpdatedDateTime { get; private set; }

    public Category Category { get; private set; }

    public Size Size { get; private set; }

    public Color Color { get; private set; }

    public Brand Brand { get; private set; }

    public Model Model { get; private set; }

    public IReadOnlyCollection<User> FavoritByUsers => _favoritByUsers.AsReadOnly();

    private Product() : base(ProductId.CreateUnique())
    {
    }

    private Product(
        ProductId productId,
        Price price,
        Quantity quantity,
        ImageUrl imgUrl,
        Category category,
        Brand brand,
        Model model,
        Size size,
        Color color)
        : base(productId)
    {
        Price = price;
        Quantity = quantity;
        ImgUrl = imgUrl;
        CreatedDateTime = DateTime.UtcNow;
        UpdatedDateTime = DateTime.UtcNow;
        Category = category;
        Brand = brand;
        Model = model;
        Color = color;
        Size = size;
    }

    public static ErrorOr<Product> Create(
        decimal price,
        int quantity,
        string imgUrl,
        Category category,
        Brand brand,
        Model model,
        Size size,
        Color color)
    {
        var imgResult = ImageUrl.Create(imgUrl);

        if (imgResult.IsError)
            return imgResult.Errors;

        var quantityResult = Quantity.Create(quantity);

        if (quantityResult.IsError)
            return quantityResult.Errors;

        return new Product(
            ProductId.CreateUnique(),
            Price.Create(price),
            quantityResult.Value,
            imgResult.Value,
            category,
            brand,
            model,
            size,
            color);
    }

    public void AddFavoritProduct(User user)
    {
        _favoritByUsers.Add(user);
    }
}