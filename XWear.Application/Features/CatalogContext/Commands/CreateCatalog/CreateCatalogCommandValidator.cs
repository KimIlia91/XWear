using FluentValidation;
using XWear.Application.Common.Resources;

namespace XWear.Application.Features.CatalogContext.Commands.CreateCatalog
{
    public class CreateCatalogCommandValidator : AbstractValidator<CreateCatalogCommand>
    {
        public CreateCatalogCommandValidator()
        {
            RuleFor(command => command.Name)
                .NotEmpty()
                .WithMessage(ErrorResources.Required)
                .MaximumLength(50)
                .WithMessage("Max lenghs 50");
        }
    }
}
