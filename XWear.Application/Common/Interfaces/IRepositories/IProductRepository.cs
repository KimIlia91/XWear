using XWear.Domain.Catalog.Entities;
using XWear.Domain.Catalog.ValueObjects;

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

    Task<FavoriteProduct> AddFavoriteProductAsync(
        FavoriteProduct favoritProduct,
        CancellationToken cancellationToken);
}
