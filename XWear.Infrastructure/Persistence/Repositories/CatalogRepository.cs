using Microsoft.EntityFrameworkCore;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Domain.EntitiesCatalog.CatalogEntity;

namespace XWear.Infrastructure.Persistence.Repositories
{
    public class CatalogRepository : ICatalogRepository
    {
        private readonly ApplicationDbContext _context;

        public CatalogRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Catalog>> GetCatalogsAsync(
            CancellationToken cancellationToken)
        {
            return await _context.Catalogs
                .Include(c => c.Categories)
                    .ThenInclude(c => c.Products)
                        .ThenInclude(p => p.Model)
                .ToListAsync(cancellationToken);
        }
    }
}
