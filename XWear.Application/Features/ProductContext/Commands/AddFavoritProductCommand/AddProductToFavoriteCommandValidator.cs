using FluentValidation;
using XWear.Application.Common.Resources;

namespace XWear.Application.Features.ProductContext.Commands.AddFavoritProductCommand;

public class AddProductToFavoriteCommandValidator 
    : AbstractValidator<AddProductToFavoriteCommand>
{
    public AddProductToFavoriteCommandValidator()
    {
        RuleFor(command => command.ProductId)
            .NotEmpty()
            .WithMessage(ErrorResources.Required);
    }
}
