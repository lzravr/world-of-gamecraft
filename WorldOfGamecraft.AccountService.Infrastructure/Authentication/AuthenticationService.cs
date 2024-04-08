using System.Security.Cryptography;
using WorldOfGamecraft.AccountService.Application.Authentication;
using WorldOfGamecraft.AccountService.Domain.Accounts;

namespace WorldOfGamecraft.AccountService.Infrastructure.Authentication;
internal sealed class AuthenticationService : IAuthenticationService
{
    public (byte[], byte[]) GetPasswordHashAndSalt(string password, CancellationToken cancellationToken = default)
    {
        using var hmac = new HMACSHA512();
        var passwordSalt = hmac.Key;
        var passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        return (passwordHash, passwordSalt);
    }

    public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using var hmac = new HMACSHA512(passwordSalt);
        var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        return computedHash.SequenceEqual(passwordHash);
    }
}
