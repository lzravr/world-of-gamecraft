using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography.X509Certificates;
using WorldOfGamecraft.CharacterService.Domain.Characters;
using WorldOfGamecraft.CharacterService.Domain.Items;

namespace WorldOfGamecraft.CharacterService.Infrastructure.Repositories;
public sealed class CharacterRepository : Repository<Character, Guid>, ICharacterRepository
{
    public CharacterRepository(CharactersDbContext dbContext) : base(dbContext)
    {
    }

    public override async Task<Character?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var query = from character in DbContext.Set<Character>()
                    join item in DbContext.Set<Item>()
                    on character.Id equals item.CharacterId into items
                    select new Character
                    {
                        Id = character.Id,
                        Name = character.Name,
                        Health = character.Health,
                        Mana = character.Mana,
                        BaseStrength = character.BaseStrength,
                        BaseAgility = character.BaseAgility,
                        BaseIntelligence = character.BaseIntelligence,
                        BaseFaith = character.BaseFaith,
                        CreatedBy = character.CreatedBy,
                        Items = items.Select(i => new Item
                        {
                            Id = i.Id,
                            Name = i.Name,
                            Description = i.Description,
                            BonusStrength = i.BonusStrength,
                            BonusAgility = i.BonusAgility,
                            BonusIntelligence = i.BonusIntelligence,
                            BonusFaith = i.BonusFaith,
                            CharacterId = i.CharacterId
                        }).ToList()
                    };

        var result = await query.FirstOrDefaultAsync();

        return result;
    }
}
