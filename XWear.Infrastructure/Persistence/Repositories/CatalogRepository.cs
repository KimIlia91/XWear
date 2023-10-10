using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using XWear.Contracts.Catalog.Responses;
using XWear.Application.Common.Interfaces.IRepositories;

namespace XWear.Infrastructure.Persistence.Repositories;

public class CatalogRepository : ICatalogRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CatalogRepository(
        ApplicationDbContext context,
        IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<IEnumerable<CatalogResponse>> GetCatalogAsync(
        CancellationToken cancellationToken)
    {
        return await _context.Catalogs
            .ProjectToType<CatalogResponse>(_mapper.Config)
            .ToListAsync(cancellationToken);
    }
}
