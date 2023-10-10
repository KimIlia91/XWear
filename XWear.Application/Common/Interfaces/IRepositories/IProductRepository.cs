using XWear.Domain.Catalog.Entities.CatalogEntity.ValueObjects;
using XWear.Domain.Catalog.Entities.FavoritParoductEntity;
using XWear.Domain.Catalog.Entities.ProductEntity;

namespace XWear.Application.Common.Interfaces.IRepositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProductsAsync(
        CancellationToken cancellationToken);

    Task<IEnumerable<Product>> GetProductByCatalogIdAsync(
        CatalogId catalogId,
        CancellationToken cancellationToken);

    Task<IEnumerable<Product>> GetFavoritUserProductsAsync(
        CancellationToken cancellationToken);

    Task<FavoritProduct> AddFavoriteProductAsync(
        FavoritProduct favoritProduct,
        CancellationToken cancellationToken);
}
