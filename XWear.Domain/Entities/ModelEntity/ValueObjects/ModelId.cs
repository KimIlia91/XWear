﻿using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.ModelEntity.ValueObjects;

public sealed class ModelId : ValueObject
{
    public Guid Value { get; private set; }

    private ModelId(Guid value)
    {
        Value = value;
    }

    public static ModelId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public static ModelId CreateEmpty()
    {
        return new(Guid.Empty);
    }

    public static ModelId Create(Guid value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
