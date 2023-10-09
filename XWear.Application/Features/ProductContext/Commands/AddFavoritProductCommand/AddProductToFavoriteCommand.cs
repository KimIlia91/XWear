using ErrorOr;
using MediatR;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Commands.AddFavoritProductCommand;

public record AddProductToFavoriteCommand(Guid ProductId) : IRequest<ErrorOr<AddedFavoritProductResult>>;
