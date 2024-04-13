namespace WorldOfGamecraft.CharacterService.Domain.Items;
public interface IItemRepository
{
    Task<List<Item>> GetAllAsync(CancellationToken cancellationToken);
    Task<Item> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    void Add(Item item);
    void Update(Item item);
    void Delete(Item item);
}
