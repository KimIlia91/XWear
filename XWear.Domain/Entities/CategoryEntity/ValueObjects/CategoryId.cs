﻿using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.CategoryEntity.ValueObjects;

public sealed class CategoryId : ValueObject
{
    public Guid Value { get; private set; }

    private CategoryId(Guid value)
    {
        Value = value;
    }

    public static CategoryId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public static CategoryId Create(Guid value)
    {
        return new(value);
    }

    public static CategoryId CreateEmpty()
    {
        return new(Guid.Empty);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
