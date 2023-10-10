using ErrorOr;
using MediatR;
using MapsterMapper;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.CatalogContext.Common;
using XWear.Domain.EntitiesCatalog.CatalogEntity;

namespace XWear.Application.Features.CatalogContext.Commands.CreateCatalog;

public class CreateCatalogCommandHandler : IRequestHandler<CreateCatalogCommand, ErrorOr<CatalogResult>>
{
    private readonly IBaseRepository<Catalog> _baseRepository;
    private readonly IMapper _mapper;

    public CreateCatalogCommandHandler(
        IBaseRepository<Catalog> baseRepository,
        IMapper mapper)
    {
        _baseRepository = baseRepository;
        _mapper = mapper;
    }

    public async Task<ErrorOr<CatalogResult>> Handle(
        CreateCatalogCommand command, 
        CancellationToken cancellationToken)
    {
        var catalog = Catalog.Create(command.Name);
        catalog = await _baseRepository.AddAsync(catalog, cancellationToken);
        var catalogResult = _mapper.Map<CatalogResult>(catalog);
        return catalogResult;
    }
}
