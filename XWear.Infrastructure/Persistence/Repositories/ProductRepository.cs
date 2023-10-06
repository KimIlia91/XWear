using Microsoft.EntityFrameworkCore;
using XWear.Domain.Entities;
using XWear.Application.Common.Interfaces.IRepositories;

namespace XWear.Infrastructure.Persistence.Repositories;

internal class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync(CancellationToken cancellationToken)
    {
        var p = await _context.Products
            .Include(p => p.Model)
            .Include(p => p.ProductSizes)
                .ThenInclude(p => p.Size)
            .ToListAsync(cancellationToken);

        return p;
    }
}