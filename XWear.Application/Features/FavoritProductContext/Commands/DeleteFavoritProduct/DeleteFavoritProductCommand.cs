using ErrorOr;
using MediatR;
using XWear.Contracts.FavoritProduct.Responses;

namespace XWear.Application.Features.FavoritProductContext.Commands.DeleteFavoritProduct;

public sealed record DeleteFavoritProductCommand(
    Guid ProductId) : IRequest<ErrorOr<DeleteFavoritProductResponse>>;