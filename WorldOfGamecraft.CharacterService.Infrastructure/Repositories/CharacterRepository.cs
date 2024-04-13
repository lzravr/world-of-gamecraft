using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using WorldOfGamecraft.CharacterService.Domain.Characters;

namespace WorldOfGamecraft.CharacterService.Infrastructure.Repositories;
public sealed class CharacterRepository : Repository<Character, Guid>, ICharacterRepository
{
    public CharacterRepository(CharactersDbContext dbContext) : base(dbContext)
    {
    }

    public override async Task<Character?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await DbContext.Set<Character>()
            .Include(c => c.Class)
            .Include(c => c.Items)
            .FirstOrDefaultAsync(entity => entity.Id.Equals(id), cancellationToken);
    }
}
