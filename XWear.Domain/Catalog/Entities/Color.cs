﻿using XWear.Domain.Catalog.ValueObjects;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.Entities;

public sealed class Color : Entity<ColorId>
{
    private readonly List<Product> _products = new();

    public string Name { get; private set; } = null!;

    public IReadOnlyList<Product> Products => _products.AsReadOnly();

    public Color(
        ColorId colorId,
        string name)
        : base(colorId)
    {
        Name = name;
    }

    public static Color Create(string name)
    {
        return new(ColorId.CreateUnique(), name);
    }
}
