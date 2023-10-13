using ErrorOr;
using MediatR;
using XWear.Application.Features.FavoritProductContext.Common;

namespace XWear.Application.Features.FavoritProductContext.Commands.DeleteFavoritProduct;

public sealed record DeleteFavoritProductCommand(
    Guid ProductId) : IRequest<ErrorOr<DeleteFavoritProductResult>>;