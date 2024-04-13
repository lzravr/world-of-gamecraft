using MediatR;
using WorldOfGamecraft.AccountService.Domain.Accounts;

namespace WorldOfGamecraft.AccountService.Application.Accounts;
public sealed record GetAccountQuery(string Username) : IRequest<string?>;
