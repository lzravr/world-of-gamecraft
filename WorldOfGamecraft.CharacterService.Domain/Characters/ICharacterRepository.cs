namespace WorldOfGamecraft.CharacterService.Domain.Characters;
public interface ICharacterRepository
{
    Task<List<Character>> GetAllAsync(CancellationToken cancellationToken);
    Task<Character?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    void Add(Character character);
}
