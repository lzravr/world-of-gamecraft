using Microsoft.EntityFrameworkCore;
using WorldOfGamecraft.CharacterService.Domain.CharacterClasses;
using WorldOfGamecraft.CharacterService.Domain.Characters;
using WorldOfGamecraft.CharacterService.Domain.Items;
using WorldOfGamecraft.Common.Data;

namespace WorldOfGamecraft.CharacterService.Infrastructure;
public sealed class CharactersDbContext : DbContext, IUnitOfWork
{
    public CharactersDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        FakeData.Init();

        var noAgi = FakeData.Items.Where(i => i.BonusAgility == 0).ToList();

        modelBuilder.Entity<Class>().HasData(FakeData.Classes);
        modelBuilder.Entity<Character>().HasData(FakeData.Characters);
        modelBuilder.Entity<Item>().HasData(FakeData.Items);
    }

    public DbSet<Character> Characters { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<Item> Items { get; set; }

}
