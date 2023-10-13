using Microsoft.EntityFrameworkCore;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Common.Interfaces.IServices;
using XWear.Application.Features.CatalogContext.Common;

namespace XWear.Infrastructure.Persistence.Repositories;

public class CatalogRepository : ICatalogRepository
{
    private readonly ApplicationDbContext _context;
    private readonly ICurrentUserService _currentUser;

    public CatalogRepository(
        ApplicationDbContext context,
        ICurrentUserService currentUser)
    {
        _currentUser = currentUser;
        _context = context;
    }

    public async Task<List<CatalogResult>> GetLastUpdatedProductsByCategoryAsync(
        CancellationToken cancellationToken)
    {
        return await _context.Catalogs
            .Select(g => new CatalogResult(
                g.Id.Value,
                g.Name,
                g.Categories.Select(c => new CategoryResult(
                    c.Name,
                    c.Products.Where(p => c.Products.Any())
                        .OrderByDescending(p => p.UpdatedDateTime)
                        .Take(1)
                        .Select(p => new ProductResult(
                            p.Id.Value,
                            p.Model.Name,
                            p.ProductSizes.First().Price.Value,
                            p.Images.First().ImgUrl.Value,
                            p.FavoritByUsers.Any(u => u.Id == _currentUser.UserId)))
                        .FirstOrDefault()))))
            .ToListAsync(cancellationToken);
    }
}
