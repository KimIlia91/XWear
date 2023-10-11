using ErrorOr;
using MediatR;
using MapsterMapper;
using XWear.Domain.Entities.CatalogEntity;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.CatalogContext.Common;

namespace XWear.Application.Features.CatalogContext.Commands.CreateCatalog;

public class CreateCatalogCommandHandler 
    : IRequestHandler<CreateCatalogCommand, ErrorOr<CatalogResult>>
{
    private readonly IMapper _mapper;
    private readonly IBaseRepository<Catalog> _baseRepository;

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

        if (catalog.IsError)
            return catalog.Errors;

        await _baseRepository.AddAsync(catalog.Value, cancellationToken);
        var catalogResult = _mapper.Map<CatalogResult>(catalog);
        return catalogResult;
    }
}