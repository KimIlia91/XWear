using FluentValidation;
using PhoneNumbers;
using XWear.Application.Common.Helpers;
using XWear.Application.Common.Resources;

namespace XWear.Application.Features.Account.Commands.Update;

public class UpdateAccountCommandValidator : AbstractValidator<UpdateAccountCommand>
{
    public UpdateAccountCommandValidator()
    {
        RuleFor(command => command.FirstName)
            .NotEmpty()
            .WithMessage(ErrorResources.Required);

        RuleFor(command => command.LastName)
            .NotEmpty()
            .WithMessage(ErrorResources.Required);

        RuleFor(command => command.Email)
            .NotEmpty()
            .WithMessage(ErrorResources.Required)
            .EmailAddress()
            .WithMessage(ErrorResources.InvalidEmailFormat);

        RuleFor(command => command.Phone)
            .NotEmpty()
            .WithMessage(ErrorResources.Required)
            .Must(ValidatorHelpers.MustBePhoneNumberFormat)
            .WithMessage(ErrorResources.InvalidPhoneFormat);
    }

    
}
