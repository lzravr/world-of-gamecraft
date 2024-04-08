namespace WorldOfGamecraft.AccountService.Domain.Accounts;
public interface IAccountRepository
{
    Task<Account?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Account?> GetByUsernameAsync(string username, CancellationToken cancellationToken = default);
    void Add(Account account);
    void Update(Account account);
}
