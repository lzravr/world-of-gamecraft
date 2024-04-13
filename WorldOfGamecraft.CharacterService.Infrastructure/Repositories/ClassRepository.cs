using Microsoft.EntityFrameworkCore;
using WorldOfGamecraft.CharacterService.Domain.CharacterClasses;
using WorldOfGamecraft.CharacterService.Domain.Characters;

namespace WorldOfGamecraft.CharacterService.Infrastructure.Repositories;
public sealed class ClassRepository : Repository<Class, Guid>, IClassRepository
{
    public ClassRepository(CharactersDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<Class?> GetByNameAsync(string name, CancellationToken cancellationToken)
    {
        return await DbContext.Set<Class>().FirstOrDefaultAsync(entity => entity.Name.Equals(name), cancellationToken);
    }
}
