﻿namespace XWear.Contracts.Catalog.Responses;

public sealed record CatalogResponse(
    Guid Id,
    string Name,
    IEnumerable<CategoryResponse> Categories);

public sealed record CategoryResponse(
    Guid Id,
    IEnumerable<ProductResponse> Products);

public sealed record ProductResponse(
    Guid Id,
    string Name,
    decimal Price,
    string ImgUrl);