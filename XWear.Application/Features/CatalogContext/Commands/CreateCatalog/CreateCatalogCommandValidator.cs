using FluentValidation;
using XWear.Application.Common.Resources;
using XWear.Domain.Common.Constants;

namespace XWear.Application.Features.CatalogContext.Commands.CreateCatalog
{
    public sealed class CreateCatalogCommandValidator 
        : AbstractValidator<CreateCatalogCommand>
    {
        public CreateCatalogCommandValidator()
        {
            RuleFor(command => command.Name)
                .NotEmpty()
                .WithMessage(ErrorResources.Required)
                .MaximumLength(EntityConstants.CatalogNameLength)
                .WithMessage("Max lenghs 50");
        }
    }
}
