﻿using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.SizeEntity.ValueObjects;

namespace XWear.Domain.Entities.SizeEntity
{
    public sealed class Size : Entity<SizeId>
    {
        private readonly List<Product> _products = new();

        public string Name { get; private set; } = null!;

        public IReadOnlyCollection<Product> Products => _products.AsReadOnly();

        public Size(
            SizeId sizeId,
            string name)
            : base(sizeId)
        {
            Name = name;
        }

        public static Size Create(string name)
        {
            return new(SizeId.CreateUnique(), name);
        }
    }
}