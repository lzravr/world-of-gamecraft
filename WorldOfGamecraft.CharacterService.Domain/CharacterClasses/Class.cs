using System.Text.Json.Serialization;
using WorldOfGamecraft.CharacterService.Domain.Characters;
using WorldOfGamecraft.Common.Abstractions;

namespace WorldOfGamecraft.CharacterService.Domain.CharacterClasses;
public sealed class Class : Entity
{
    public Class() { }
    private Class(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; set; }
    public string Description { get; set; }

    [JsonIgnore]
    public List<Character> Characters { get; set; } = new();  

    public static Class Create(string name, string description)
    {
        var characterClass = new Class(name, description);

        return characterClass;
    }
}
