using ErrorOr;
using MediatR;
using XWear.Application.Authentication.Common;

namespace XWear.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Phone,
    string Password,
    string ConfirmPassword) : IRequest<ErrorOr<AuthenticationResult>>;
