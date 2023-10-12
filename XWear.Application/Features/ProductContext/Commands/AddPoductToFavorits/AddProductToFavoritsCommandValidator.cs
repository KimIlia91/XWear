using FluentValidation;
using XWear.Application.Common.Resources;

namespace XWear.Application.Features.ProductContext.Commands.AddPoductToFavorits;

internal sealed class AddProductToFavoritsCommandValidator 
    : AbstractValidator<AddPoductToFavoritsCommand>
{
    public AddProductToFavoritsCommandValidator()
    {
        RuleFor(command => command.ProdcutId)
            .NotEmpty()
            .WithMessage(ErrorResources.Required);
    }
}
