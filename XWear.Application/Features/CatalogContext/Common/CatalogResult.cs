using Mapster;
using XWear.Domain.Catalog.Entities;

namespace XWear.Application.Features.CatalogContext.Common;

public record CatalogResult : IRegister
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Catalog, CatalogResult>();
    }
}