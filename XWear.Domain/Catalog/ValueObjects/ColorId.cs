﻿using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.ValueObjects;

public class ColorId : ValueObject
{
    public Guid Value { get; set; }

    private ColorId(Guid value)
    {
        Value = value;
    }

    public static ColorId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}