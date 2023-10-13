using ErrorOr;
using MediatR;
using XWear.Application.Features.CatalogContext.Common;

namespace XWear.Application.Features.CatalogContext.Queries.GetCatalogsWithCategories;

public record GetCatalogsWithCategoriesQuery 
    : IRequest<ErrorOr<IEnumerable<CatalogWithCategoriesResult>>>;
