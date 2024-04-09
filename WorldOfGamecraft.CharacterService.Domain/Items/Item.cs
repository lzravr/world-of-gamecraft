using WorldOfGamecraft.CharacterService.Domain.Characters;
using WorldOfGamecraft.Common.Abstractions;

namespace WorldOfGamecraft.CharacterService.Domain.Items;
public sealed class Item : Entity
{
    public Item() { }
    private Item(string name, string description, int bonusStrength, int bonusAgility, int bonusIntelligence, int bonusFaith)
    {
        Name = name;
        Description = description;
        BonusStrength = bonusStrength;
        BonusAgility = bonusAgility;
        BonusIntelligence = bonusIntelligence;
        BonusFaith = bonusFaith;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public int BonusStrength { get; set; }
    public int BonusAgility { get; set; }
    public int BonusIntelligence { get; set; }
    public int BonusFaith { get; set; }

    public Guid CharacterId { get; set; }
    public Character? Character { get; set; } = null;

    public static Item Create(string name, string description, int bonusStrength, int bonusAgility, int bonusInteligence, int bonusFaith)
    {
        var item = new Item(name, description,  bonusStrength, bonusAgility, bonusInteligence, bonusFaith);

        return item;
    }
}
