using ErrorOr;
using MediatR;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Commands.AddPoductToFavorits;

public sealed record AddPoductToFavoritsCommand(
    Guid ProdcutId) : IRequest<ErrorOr<AddProductToFavoritsResult>>;
