using FluentValidation;
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
                .NotEmpty()
                .WithMessage(ErrorResources.Required)
                .EmailAddress()
                .WithMessage(ErrorResources.InvalidEmailFormat); ;
            RuleFor(command => command.Phone)
                .NotEmpty()
                .WithMessage(ErrorResources.Required);
            RuleFor(command => command.Password)
                .NotEmpty()
                .WithMessage(ErrorResources.Required);
            RuleFor(command => command.ConfirmPassword)
                .NotEmpty()
                .WithMessage(ErrorResources.Required);
        }
    }
}
