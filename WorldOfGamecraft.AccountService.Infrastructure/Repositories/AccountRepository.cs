using Microsoft.EntityFrameworkCore;
using WorldOfGamecraft.AccountService.Domain.Accounts;

namespace WorldOfGamecraft.AccountService.Infrastructure.Repositories;
internal sealed class AccountRepository : Repository<Account, Guid>, IAccountRepository
{
    public AccountRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        
    }
    public async Task<Account?> GetByUsernameAsync(string username, CancellationToken cancellationToken)
    {
        return await DbContext.Set<Account>().FirstOrDefaultAsync(entity => entity.Username.Equals(username), cancellationToken);
    }
}
