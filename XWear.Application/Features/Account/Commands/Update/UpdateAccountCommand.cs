using ErrorOr;
using MediatR;
using XWear.Application.Features.Account.Common;

namespace XWear.Application.Features.Account.Commands.Update;

public record UpdateAccountCommand(
     string FirstName,
     string LastName,
     string Email,
     string Phone) : IRequest<ErrorOr<AccountResult>>;
