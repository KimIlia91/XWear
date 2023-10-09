using Mapster;
using XWear.Domain.Entities;

namespace XWear.Application.Features.ProductContext.Common;

public class AddedFavoritProductResult : IRegister
{
    public Guid FavoritProductId { get; set; }

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<FavoritProduct, AddedFavoritProductResult>()
          .Map(dest => dest.FavoritProductId, src => src.Id);
    }
}