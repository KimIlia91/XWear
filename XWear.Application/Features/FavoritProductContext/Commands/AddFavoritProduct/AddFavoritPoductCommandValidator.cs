using FluentValidation;
using XWear.Application.Common.Resources;

namespace XWear.Application.Features.FavoritProductContext.Commands.AddFavoritProduct;

public sealed class AddFavoritPoductCommandValidator
    : AbstractValidator<AddFavoritPoductCommand>
{
    public AddFavoritPoductCommandValidator()
    {
        RuleFor(command => command.ProdcutId)
            .NotEmpty()
            .WithMessage(ErrorResources.Required);
    }
}
