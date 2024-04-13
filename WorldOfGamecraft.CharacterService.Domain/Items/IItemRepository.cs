namespace WorldOfGamecraft.CharacterService.Domain.Items;
public interface IItemRepository
{
    Task<List<Item>> GetAllAsync();
    Task<Item> GetByIdAsync(Guid id);
    void Add(Item item);
    void Remove(Item item);
}
