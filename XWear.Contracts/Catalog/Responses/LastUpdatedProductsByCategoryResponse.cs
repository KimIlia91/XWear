using XWear.Contracts.Product.Responses;

namespace XWear.Contracts.Catalog.Responses;

public sealed record LastUpdatedProductsByCategoryResponse(
    Guid Id,
    string Name,
    IEnumerable<CategoryResponse> Categories);

public sealed record CategoryResponse(
    Guid Id,
    string Name,
    ProductResponse Product);