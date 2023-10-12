using ErrorOr;
using MediatR;
using XWear.Application.Features.FavoritProductContext.Common;

namespace XWear.Application.Features.FavoritProductContext.Commands.AddFavoritProduct;

public sealed record AddFavoritPoductCommand(
    Guid ProdcutId) : IRequest<ErrorOr<AddProductToFavoritsResult>>;
