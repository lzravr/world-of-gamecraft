using Microsoft.EntityFrameworkCore;
using WorldOfGamecraft.AccountService.Domain.Abstractions;
using WorldOfGamecraft.AccountService.Domain.Accounts;

namespace WorldOfGamecraft.AccountService.Infrastructure;
public sealed class ApplicationDbContext : DbContext, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Account> Accounts { get; set; }
}
