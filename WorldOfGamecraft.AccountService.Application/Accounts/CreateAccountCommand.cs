using MediatR;
using WorldOfGamecraft.Common;

namespace WorldOfGamecraft.AccountService.Application.Accounts;
public sealed record CreateAccountCommand(string Username, string Password, Role Role) : IRequest<Guid>;
