using WorldOfGamecraft.CharacterService.Domain.Items;

namespace WorldOfGamecraft.CharacterService.Infrastructure.Repositories;
public sealed class ItemRepository : Repository<Item, Guid>, IItemRepository
{
    public ItemRepository(CharactersDbContext dbContext) : base(dbContext)
    {
    }
}
