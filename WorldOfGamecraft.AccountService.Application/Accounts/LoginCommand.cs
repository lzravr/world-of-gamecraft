using MediatR;

namespace WorldOfGamecraft.AccountService.Application.Accounts;
public sealed record LoginCommand(string Username, string Password): IRequest<Tokens>;
