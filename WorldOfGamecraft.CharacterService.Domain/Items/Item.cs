using System.Text.Json.Serialization;
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

    [JsonIgnore]
    public Guid CharacterId { get; set; }
    [JsonIgnore]
    public Character? Character { get; set; } = null;

    public static Item Create(string name, string description, int bonusStrength, int bonusAgility, int bonusInteligence, int bonusFaith)
    {
        //name = GenerateItemName(name, bonusStrength, bonusAgility, bonusInteligence, bonusFaith);
        var item = new Item(name, description,  bonusStrength, bonusAgility, bonusInteligence, bonusFaith);

        return item;
    }

    private static string GenerateItemName(string name, int bonusStrength, int bonusAgility, int bonusInteligence, int bonusFaith)
    {
        var stats = new int[] { bonusStrength, bonusAgility, bonusInteligence, bonusFaith };
        var maxStat = stats.Max();

        var fullName = name + " ";

        if (maxStat == bonusStrength) fullName += ItemSufixes.STRENGTH;
        if (maxStat == bonusAgility) fullName += ItemSufixes.AGILITY;
        if (maxStat == bonusInteligence) fullName += ItemSufixes.INTELIGENCE;
        if (maxStat == bonusFaith) fullName += ItemSufixes.FAITH;

        return fullName;
    }
}

public static class ItemSufixes
{
    public static readonly string STRENGTH = "Of The Bear";
    public static readonly string AGILITY = "Of The Cobra";
    public static readonly string INTELIGENCE = "Of The Owl";
    public static readonly string FAITH = "Of The Unicorn";
}
