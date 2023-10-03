using ErrorOr;
using MediatR;
using XWear.Application.Features.Account.Common;

namespace XWear.Application.Features.Account.Queries.GetAccount;

public record GetAccountQuery : IRequest<ErrorOr<AccountResult>>;
