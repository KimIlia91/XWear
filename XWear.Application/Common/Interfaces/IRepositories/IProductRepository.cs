using XWear.Application.Features.ProductContext.Common;
using XWear.Domain.Entities.CatalogEntity.ValueObjects;
using XWear.Domain.Entities.CategoryEntity.ValueObjects;
using XWear.Domain.Entities.ColorEntity.ValueObjects;
using XWear.Domain.Entities.ModelEntity.ValueObjects;
using XWear.Domain.Entities.ProductSizeEntity.ValueObjects;
using XWear.Domain.Entities.UserEntity.ValueObjects;

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

    Task<ProductByIdResult?> GetByProductSizeIdAsync(
        ProductSizeId productId,
        CancellationToken cancellationToken);

    Task<List<ProductResult>> GetProductsByCategoryIdAsync(
        CategoryId categoryId,
        UserId userId,
        CancellationToken cancellationToken);
}
