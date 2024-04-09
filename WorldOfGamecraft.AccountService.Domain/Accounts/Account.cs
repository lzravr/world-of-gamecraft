using WorldOfGamecraft.AccountService.Domain.Accounts.Events;
using WorldOfGamecraft.Common.Abstractions;

namespace WorldOfGamecraft.AccountService.Domain.Accounts;
public class Account : Entity
{
    private Account(string username, byte[] passwordHash, byte[] passwordSalt, string? refreshToken, DateTime? validUntil, Role role)
    {
        Username = username;
        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
        RefreshToken = refreshToken;
        ValidUntil = validUntil;
        Role = role;
    }

    public string Username { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? ValidUntil { get; set; }
    public Role Role { get; set; }

    public static Account Create(string username, byte[] passwordHash, byte[] passwordSalt, string? refreshToken, DateTime? validUntil, Role role)
    {
        var account = new Account(username, passwordHash, passwordSalt, refreshToken, validUntil, role);

        account.RaiseDomainEvent(new AccountCreatedDomainEvent(account.Id));

        return account;
    }

    public void SetRefreshToken(string refreshToken)
    {

    }
}
