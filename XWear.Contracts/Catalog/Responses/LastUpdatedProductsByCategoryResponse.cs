namespace XWear.Contracts.Catalog.Responses;

public sealed record LastUpdatedProductsByCategoryResponse(
    Guid Id,
    string Name,
    IEnumerable<CategoryResponse> Categories);

public sealed record CategoryResponse(
    string Name,
    ProductResponse Product);

public sealed record ProductResponse(
    Guid Id,
    string Name,
    decimal Price,
    string ImgUrl,
    bool IsFavorit);