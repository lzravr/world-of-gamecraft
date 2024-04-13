namespace WorldOfGamecraft.CharacterService.Domain.CharacterClasses;
public interface IClassRepository
{
    public Task<List<Class>> GetAllAsync(CancellationToken cancellationToken);
    public Task<Class?> GetByNameAsync(string name, CancellationToken cancellationToken);
}
