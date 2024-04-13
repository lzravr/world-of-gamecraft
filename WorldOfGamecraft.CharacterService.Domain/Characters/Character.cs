using WorldOfGamecraft.CharacterService.Domain.CharacterClasses;
using WorldOfGamecraft.CharacterService.Domain.Items;
using WorldOfGamecraft.Common.Abstractions;

namespace WorldOfGamecraft.CharacterService.Domain.Characters;
public sealed class Character : Entity
{
    public Character() { }

    public Character(string name, int health, int mana, int baseStrength, int baseAgility, int baseIntelligence, int baseFaith, Guid classId, Guid createdBy)
    {
        Name = name;
        Health = health;
        Mana = mana;
        BaseStrength = baseStrength;
        BaseAgility = baseAgility;
        BaseIntelligence = baseIntelligence;
        BaseFaith = baseFaith;
        ClassId = classId;
        CreatedBy = createdBy;
    }

    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana {  get; set; }
    public int BaseStrength { get; set; }
    public int BaseAgility { get; set; }
    public int BaseIntelligence { get; set; }
    public int BaseFaith { get; set; }
    public Guid CreatedBy { get; set; }

    public Guid ClassId { get; set; }
    public Class Class { get; set; }
    public List<Item> Items { get; set; } = new();

    public static Character Create(string name, int health, int mana, int baseStrength, int baseAgility, int baseIntelligence, int baseFaith, Guid classId, Guid createdBy)
    {
        var character = new Character(name, health, mana, baseStrength, baseAgility, baseIntelligence, baseFaith, classId, createdBy);

        return character;
    }
}
