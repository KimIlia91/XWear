using ErrorOr;
using MediatR;
using XWear.Application.Features.Account.Common;

namespace XWear.Application.Features.Account.Queries.GetAccount;

public class GetAccountQuery : IRequest<ErrorOr<AccountResult>> { }
