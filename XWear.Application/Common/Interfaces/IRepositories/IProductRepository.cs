﻿using XWear.Domain.Entities.ColorEntity.ValueObjects;
using XWear.Domain.Entities.ModelEntity.ValueObjects;
using XWear.Domain.Entities.CategoryEntity.ValueObjects;
using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Application.Features.ProductContext.Queries.GetProductPage;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Common.Interfaces.IRepositories;

public interface IProductRepository
{
    Task<IEnumerable<ProductResult>> GetProductPageAsync(
        int pageNumber,
        int pageSize,
        List<string> size,
        ModelId modelId,
        ColorId colorId,
        CategoryId categoryId,
        CancellationToken cancellationToken);

    Task<ProductByIdResult?> GetProductByIdAsync(
        ProductId productId, 
        CancellationToken cancellationToken); 
}
