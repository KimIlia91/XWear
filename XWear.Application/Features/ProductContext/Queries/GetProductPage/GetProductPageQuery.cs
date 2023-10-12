using ErrorOr;
using Mapster;
using MediatR;
using XWear.Domain.Entities.CategoryEntity.ValueObjects;
using XWear.Domain.Entities.ColorEntity.ValueObjects;
using XWear.Domain.Entities.ModelEntity.ValueObjects;
using XWear.Domain.Entities.ProductEntity;

namespace XWear.Application.Features.ProductContext.Queries.GetProductPage;

public sealed class GetProductPageQuery : IRequest<ErrorOr<IEnumerable<ProductResult>>>
{
    public PageFilter Filter { get; set; } = new PageFilter();
}

public sealed class PageFilter
{
    public int Page { get; set; } = 1;

    public int PageSize { get; set; } = 20;

    public List<string> Sizes { get; set; } = new List<string>();

    public ModelId ModelId { get; set; } = ModelId.CreateEmpty();

    public ColorId ColorId { get; set; } = ColorId.CreateEmpty();

    public CategoryId CategoryId { get; set; } = CategoryId.CreateEmpty();
}

public sealed class PageDto<T>
{
}

public sealed class ProductResult : IRegister
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public string ImgUrl { get; set; } = null!;

    public bool IsFavorit { get; set; }

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Product, ProductResult>()
            .Map(dest => dest.Name, src => src.Model.Name);
    }
}