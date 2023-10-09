using XWear.Domain.Entities;

namespace XWear.Application.Common.Interfaces.IRepositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProductsAsync(
        CancellationToken cancellationToken);

    Task<IEnumerable<Product>> GetProductByCatalogIdAsync(
        Guid catalogId,
        CancellationToken cancellationToken);

    Task<IEnumerable<Product>> GetFavoritUserProductsAsync(
        CancellationToken cancellationToken);

    Task<FavoritProduct> AddFavoriteProductAsync(
        FavoritProduct favoritProduct,
        CancellationToken cancellationToken);
}
