using Mapster;
using XWear.Domain.Entities.CatalogEntity;
using XWear.Domain.Entities.CategoryEntity;

namespace XWear.Application.Features.CatalogContext.Common;

public sealed class CatalogWithCategoriesResult : IRegister
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public IEnumerable<CatalogCategoryResult> Categories { get; set; } 
        = new List<CatalogCategoryResult>();

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Catalog, CatalogWithCategoriesResult>()
            .Map(dest => dest.Id, src => src.Id.Value)
            .Map(dest => dest.Categories, src => src.Categories);
    }
}

public sealed class CatalogCategoryResult : IRegister
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Category, CatalogCategoryResult>()
            .Map(dest => dest.Id, src => src.Id.Value);
    }
}