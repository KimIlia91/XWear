using Microsoft.EntityFrameworkCore;
using XWear.Contracts.Catalog.Responses;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Common.Interfaces.IServices;

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

    public async Task<List<CatalogResponse>> GetLastUpdatedProductsByCategoryAsync(
        CancellationToken cancellationToken)
    {
        return await _context.Catalogs
            .Select(g => new CatalogResponse(
                g.Id.Value,
                g.Name,
                g.Categories.Select(c => new CategoryResponse(
                    c.Products.Where(p => c.Products.Any())
                        .OrderByDescending(p => p.UpdatedDateTime)
                        .Take(1)
                        .Select(p => new ProductResponse(
                            p.Id.Value,
                            p.Model.Name,
                            p.Price.Value,
                            p.Images.FirstOrDefault().ImgUrl.Value,
                            p.FavoritByUsers.Any(u => u.Id == _currentUser.UserId)))))))
            .ToListAsync(cancellationToken);
    }
}
