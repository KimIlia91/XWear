using FluentValidation;
using XWear.Application.Common.Resources;

namespace XWear.Application.Features.FavoritProductContext.Commands.AddFavoritProduct;

internal sealed class AddFavoritPoductCommandValidator
    : AbstractValidator<AddFavoritPoductCommand>
{
    public AddFavoritPoductCommandValidator()
    {
        RuleFor(command => command.ProdcutId)
            .NotEmpty()
            .WithMessage(ErrorResources.Required);
    }
}
