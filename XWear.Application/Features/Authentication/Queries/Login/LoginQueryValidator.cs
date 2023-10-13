using FluentValidation;
using XWear.Application.Common.Helpers;
using XWear.Application.Common.Resources;

namespace XWear.Application.Features.Authentication.Queries.Login;

public sealed class LoginQueryValidator : AbstractValidator<LoginQuery>
{
    public LoginQueryValidator()
    {
        RuleFor(command => command.Email)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotEmpty()
            .WithMessage(ErrorResources.Required)
            .EmailAddress()
            .WithMessage(ErrorResources.InvalidEmailFormat);

        RuleFor(command => command.Password)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotEmpty()
            .WithMessage(ErrorResources.Required)
            .Must(ValidatorHelpers.PasswordPolicy)
            .WithMessage(ErrorResources.PasswordPolicy);
    }
}
