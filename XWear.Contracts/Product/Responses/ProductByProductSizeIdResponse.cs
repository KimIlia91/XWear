namespace XWear.Contracts.Product.Responses;

public sealed record ProductByProductSizeIdResponse(
    Guid Id,
    IEnumerable<ProductImageUrlResponse> Images,
    ProductCategoryResponse Category,
    ProductBrandResponse Brand,
    ProductModelResponse Model,
    ProductColorResponse Color,
    IEnumerable<ProductSizeResponse> ProductSizes);

public sealed record ProductImageUrlResponse(
    string ImageUrl);

public sealed record ProductSizeResponse(
    Guid Id,
    string Size,
    decimal Price,
    bool IsSelected);

public sealed record ProductColorResponse(
    Guid Id,
    string Name);

public sealed record ProductModelResponse(
    Guid Id,
    string Name);

public sealed record ProductBrandResponse(
    Guid Id,
    string Name);

public sealed record ProductCategoryResponse(
    Guid Id,
    string Name);
