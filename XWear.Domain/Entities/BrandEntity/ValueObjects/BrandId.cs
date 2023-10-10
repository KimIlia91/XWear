﻿using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.BrandEntity.ValueObjects;

public sealed class BrandId : ValueObject
{
    public Guid Value { get; private set; }

    private BrandId(Guid value)
    {
        Value = value;
    }

    public static BrandId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
