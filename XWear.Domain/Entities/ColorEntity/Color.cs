﻿using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.ColorEntity.ValueObjects;
using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Errors;
using ErrorOr;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities.CatalogEntity.ValueObjects;

namespace XWear.Domain.Entities.ColorEntity;

public sealed class Color : Entity<ColorId>
{
    private readonly List<Product> _products = new();

    public string Name { get; private set; } = null!;

    public ColorEnum Value { get; private set; }

    public IReadOnlyCollection<Product> Products => _products.ToList();

    private Color() : base(ColorId.CreateUnique())
    {
    }

    internal Color(
        ColorId colorId,
        string name,
        ColorEnum value)
        : base(colorId)
    {
        Id = colorId;
        Name = name;
        Value = value;
    }

    public static ErrorOr<Color> Create(string name)
    {
        if (string.IsNullOrEmpty(name) || name.Length > EntityConstants.ColorNameLength)
            return Errors.Color.InvalidNameLength;

        var result = EnumHelper.GetEnumFromDescription<ColorEnum>(name);

        if (result.IsError)
            return Errors.Color.ColorNotFound;

        return new Color(ColorId.CreateUnique(), name, result.Value);
    }
}
