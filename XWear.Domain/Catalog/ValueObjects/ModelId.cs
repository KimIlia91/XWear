﻿using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.ValueObjects;

public class ModelId : ValueObject
{
    public Guid Value { get; set; }

    private ModelId(Guid value)
    {
        Value = value;
    }

    public static ModelId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
