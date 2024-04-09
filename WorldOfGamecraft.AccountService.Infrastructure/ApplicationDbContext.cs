using Microsoft.EntityFrameworkCore;
using WorldOfGamecraft.AccountService.Domain.Accounts;
using WorldOfGamecraft.Common.Data;

namespace WorldOfGamecraft.AccountService.Infrastructure;
public sealed class ApplicationDbContext : DbContext, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>()
            .HasIndex(a => a.Username)
            .IsUnique();
    }

    public DbSet<Account> Accounts { get; set; }
}
