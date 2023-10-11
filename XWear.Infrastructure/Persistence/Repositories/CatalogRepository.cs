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

    public async Task<List<CatalogResponse>> GetLastUpdatedProductsByCategoryAsync(
        CancellationToken cancellationToken)
    {
        //return await _context.Catalogs
        //    .Select(c => new CatalogResponse(
        //        c.Id.Value,
        //        c.Name,
        //        c.Categories.Select(cat => new CategoryResponse(
        //            cat.Id.Value,
        //            cat.Products
        //            .OrderByDescending(p => p.UpdatedDateTime)
        //            .Take(1)
        //            .Select(p => new ProductResponse(
        //                p.Id.Value,
        //                p.Model.Name,
        //                p.Price.Value))))))
        //    .ToListAsync(cancellationToken);
        throw new NotImplementedException();
    }
}
