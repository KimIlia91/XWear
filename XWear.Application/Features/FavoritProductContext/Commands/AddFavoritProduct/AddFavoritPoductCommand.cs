using ErrorOr;
using MediatR;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.FavoritProductContext.Commands.AddFavoritProduct;

public sealed record AddFavoritPoductCommand(
    Guid ProdcutId) : IRequest<ErrorOr<AddProductToFavoritsResult>>;
