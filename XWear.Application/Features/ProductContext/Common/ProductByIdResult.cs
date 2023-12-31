﻿using Mapster;
using XWear.Domain.Entities.BrandEntity;
using XWear.Domain.Entities.CategoryEntity;
using XWear.Domain.Entities.ColorEntity;
using XWear.Domain.Entities.ImageEntity;
using XWear.Domain.Entities.ModelEntity;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.ProductSizeEntity;

namespace XWear.Application.Features.ProductContext.Common;

public sealed class ProductByIdResult : IRegister
{
    public Guid Id { get; set; }

    public IEnumerable<ProductImageUrlResult> Images { get; set; } = new List<ProductImageUrlResult>();

    public ProductCategoryResult Category { get; set; } = new ProductCategoryResult();

    public ProductBrandResult Brand { get; set; } = new ProductBrandResult();

    public ProductModelResult Model { get; set; } = new ProductModelResult();

    public ProductColorResult Color { get; set; } = new ProductColorResult();

    public IEnumerable<ProductSizeResult> ProductSizes { get; set; } = new List<ProductSizeResult>();

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Product, ProductByIdResult>()
            .Map(dest => dest.Id, src => src.Id.Value);
    }
}

public class ProductImageUrlResult : IRegister
{
    public string ImageUrl { get; set; } = null!;

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Image, ProductImageUrlResult>()
            .Map(dest => dest.ImageUrl, src => src.ImgUrl.Value);
    }
}

public class ProductSizeResult : IRegister
{
    public Guid Id { get; set; }

    public string Size { get; set; } = null!;

    public decimal Price { get; set; }

    public bool IsSelected { get; set; } = false;

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<ProductSize, ProductSizeResult>()
            .Map(dest => dest.Id, src => src.Id.Value)
            .Map(dest => dest.Size, src => src.Size.Name)
            .Map(dest => dest.Price, src => src.Price.Value)
            .Ignore(dest => dest.IsSelected);
    }
}

public class ProductColorResult : IRegister
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Color, ProductColorResult>()
            .Map(dest => dest.Id, src => src.Id.Value);
    }
}

public class ProductModelResult : IRegister
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Model, ProductModelResult>()
            .Map(dest => dest.Id, src => src.Id.Value);
    }
}

public class ProductBrandResult : IRegister
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Brand, ProductBrandResult>()
            .Map(dest => dest.Id, src => src.Id.Value);
    }
}

public class ProductCategoryResult : IRegister
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Category, ProductCategoryResult>()
            .Map(dest => dest.Id, src => src.Id.Value);
    }
}