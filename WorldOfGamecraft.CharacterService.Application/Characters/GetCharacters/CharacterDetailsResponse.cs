using WorldOfGamecraft.CharacterService.Domain.CharacterClasses;
using WorldOfGamecraft.CharacterService.Domain.Items;

namespace WorldOfGamecraft.CharacterService.Application.Characters.GetCharacters;
public sealed class CharacterDetailsResponse
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public int BaseStrength { get; set; }
    public int BaseAgility { get; set; }
    public int BaseIntelligence { get; set; }
    public int BaseFaith { get; set; }
    public Class Class { get; set; }
    public List<Item> Items { get; set; } = new();
}
