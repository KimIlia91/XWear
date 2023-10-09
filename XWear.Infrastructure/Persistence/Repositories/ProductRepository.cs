using Microsoft.EntityFrameworkCore;
using XWear.Domain.Entities;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Common.Interfaces.IServices;

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

    public async Task<IEnumerable<Product>> GetAllProductsAsync(
        CancellationToken cancellationToken)
    {
        return await _context.Products
            .Include(p => p.Model)
            .Include(p => p.Category)
                .ThenInclude(p => p.Catalog)
            .ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<Product>> GetProductByCatalogIdAsync(
        Guid catalogId,
        CancellationToken cancellationToken)
    {
        return await _context.Products
            .Include(p => p.Model)
            .AsNoTracking()
            .Where(p => p.Category.CatalogId == catalogId)
            .ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<Product>> GetFavoritUserProductsAsync(
        CancellationToken cancellationToken)
    {
        if (_currentUserService.UserId == Guid.Empty)
            return new List<Product>();

        var favoritProducts = await _context.Products
            .Include(p => p.FavoritProducts)
            .AsNoTracking()
            .Where(p => p.FavoritProducts.Any(p => p.UserId == _currentUserService.UserId))
            .ToListAsync(cancellationToken);

        return favoritProducts;
    }

    public async Task<FavoritProduct> AddFavoriteProductAsync(
        FavoritProduct favoritProduct, 
        CancellationToken cancellationToken)
    {
        await _context.FavoritProducts.AddAsync(favoritProduct, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return favoritProduct;
    }
}