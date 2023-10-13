using FluentValidation;
using XWear.Application.Common.Resources;

namespace XWear.Application.Features.FavoritProductContext.Commands.DeleteFavoritProduct;

public sealed class DeleteFavoritProductCommandValidator 
    : AbstractValidator<DeleteFavoritProductCommand>
{
    public DeleteFavoritProductCommandValidator()
    {
        RuleFor(command => command.ProductId)
            .NotEmpty()
            .WithMessage(ErrorResources.Required);
    }
}
