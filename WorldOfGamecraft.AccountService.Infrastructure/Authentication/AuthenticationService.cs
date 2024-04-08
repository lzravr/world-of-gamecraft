using System.Security.Cryptography;
using WorldOfGamecraft.AccountService.Application.Authentication;
using WorldOfGamecraft.AccountService.Domain.Accounts;

namespace WorldOfGamecraft.AccountService.Infrastructure.Authentication;
internal sealed class AuthenticationService : IAuthenticationService
{
    public Task<string> CreateAccountAsync(Account account, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public (byte[], byte[]) GetPasswordHashAndSaltAsync(string password, CancellationToken cancellationToken = default)
    {
        using var hmac = new HMACSHA512();
        var passwordSalt = hmac.Key;
        var passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        return (passwordHash, passwordSalt);
    }
}
