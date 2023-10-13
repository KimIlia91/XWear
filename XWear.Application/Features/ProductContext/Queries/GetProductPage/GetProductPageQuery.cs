using ErrorOr;
using Mapster;
using MediatR;
using XWear.Application.Features.ProductContext.Common;
using XWear.Domain.Entities.CategoryEntity.ValueObjects;
using XWear.Domain.Entities.ColorEntity.ValueObjects;
using XWear.Domain.Entities.ModelEntity.ValueObjects;

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