using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Domain.Entities;

namespace XWear.Infrastructure.Persistence.Repositories
{
    public class CatalogRepository : ICatalogRepository
    {
        private readonly ApplicationDbContext _context;

        public CatalogRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Catalog> GetCatalogs()
        {
            return _context.Catalogs.ToList();
        }
    }
}
