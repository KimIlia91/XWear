using Microsoft.EntityFrameworkCore;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Common.Interfaces.IServices;
using XWear.Domain.Catalog.Entities.CatalogEntity.ValueObjects;
using XWear.Domain.Catalog.Entities.FavoritParoductEntity;
using XWear.Domain.Catalog.Entities.ProductEntity;

namespace XWear.Infrastructure.Persistence.Repositories;

internal class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;
    private readonly ICurrentUserService _currentUserService;

    public ProductRepository(
        ApplicationDbContext context,
        ICurrentUserService currentUserService)
    {
        _context = context;
        _currentUserService = currentUserService;
    }

    public Task<FavoritProduct> AddFavoriteProductAsync(
        FavoritProduct favoritProduct, 
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetAllProductsAsync(
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Product>> GetFavoritUserProductsAsync(
        CancellationToken cancellationToken)
    {
        return await _context.Products
            .Include(p => p.Model)
            .Where(p => p.FavoriteByUsers
            .Any(fp => fp.UserId == _currentUserService.UserId))
            .ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<Product>> GetProductByCatalogIdAsync(
        CatalogId catalogId, 
        CancellationToken cancellationToken)
    {
        return await _context.Products
            .Include(p => p.Model)
            .Where(p => p.Category.CatalogId == catalogId)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }
}