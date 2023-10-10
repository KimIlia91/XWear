using ErrorOr;
using MediatR;
using XWear.Application.Features.CatalogContext.Common;

namespace XWear.Application.Features.CatalogContext.Commands.CreateCatalog;

public record CreateCatalogCommand(
    string Name) : IRequest<ErrorOr<CatalogResult>>;
