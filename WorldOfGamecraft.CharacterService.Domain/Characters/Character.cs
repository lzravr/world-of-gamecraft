using WorldOfGamecraft.CharacterService.Domain.CharacterClasses;
using WorldOfGamecraft.CharacterService.Domain.Items;
using WorldOfGamecraft.Common.Abstractions;

namespace WorldOfGamecraft.CharacterService.Domain.Characters;
public sealed class Character : Entity
{
    public Character() { }

    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana {  get; set; }
    public int BaseStrength { get; set; }
    public int BaseAgility { get; set; }
    public int BaseIntelligence { get; set; }
    public int BaseFaith { get; set; }

    public Guid ClassId { get; set; }
    public Class Class { get; set; }
    public List<Item> Items { get; set; } = new();
}
