﻿using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.FavoritParoductEntity.ValueObjects;

public sealed class FavoriteProductId : ValueObject
{
    public Guid Value { get; private set; }

    private FavoriteProductId(Guid value)
    {
        Value = value;
    }

    public static FavoriteProductId CreateUnique()
    {
        return new FavoriteProductId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}