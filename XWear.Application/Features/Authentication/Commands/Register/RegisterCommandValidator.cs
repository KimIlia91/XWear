using FluentValidation;
using XWear.Application.Common.Helpers;
using XWear.Application.Common.Resources;

namespace XWear.Application.Features.Authentication.Commands.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(command => command.FirstName)
                .NotEmpty()
                .WithMessage(ErrorResources.Required);

            RuleFor(command => command.LastName)
                .NotEmpty()
                .WithMessage(ErrorResources.Required);   
            
            RuleFor(command => command.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage(ErrorResources.Required)
                .EmailAddress()
                .WithMessage(ErrorResources.InvalidEmailFormat);

            RuleFor(command => command.Phone)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage(ErrorResources.Required)
                .Must(ValidatorHelpers.MustBePhoneNumberFormat)
                .WithMessage(ErrorResources.InvalidPhoneFormat);

            RuleFor(command => command.Password)
                .NotEmpty()
                .WithMessage(ErrorResources.Required);

            RuleFor(command => command.ConfirmPassword)
                .NotEmpty()
                .WithMessage(ErrorResources.Required);
        }
    }
}
