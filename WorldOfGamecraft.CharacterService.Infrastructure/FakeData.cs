using Bogus;
using WorldOfGamecraft.CharacterService.Domain.CharacterClasses;
using WorldOfGamecraft.CharacterService.Domain.Characters;
using WorldOfGamecraft.CharacterService.Domain.Items;

namespace WorldOfGamecraft.CharacterService.Infrastructure;
public static class FakeData
{
    public static List<Character> Characters { get; set; } = new();
    public static List<Class> Classes { get; set; } = new();
    public static List<Item> Items { get; set; } = new();

    public static void Init()
    {
        string[] types = { "Warrior", "Rogue", "Mage", "Priest", "Elf", "Necromancer" };

        int br = 0;

        var classFaker = new Faker<Class>()
            .RuleFor(c => c.Description, f => f.Lorem.Sentence())
            .RuleFor(c => c.Name, f => types[br++]);

        Classes = classFaker.GenerateBetween(6, 6);


        string[] itemName = {"orchid",
                            "cyclone",
                            "force_staff",
                            "dagon",
                            "necronomicon",
                            "ultimate_scepter",
                            "refresher",
                            "assault",
                            "heart",
                            "black_king_bar",
                            "aegis",
                            "shivas_guard",
                            "bloodstone",
                            "sphere",
                            "vanguard",
                            "blade_mail",
                            "soul_booster",
                            "hood_of_defiance",
                            "rapier",
                            "monkey_king_bar",
                            "radiance",
                            "butterfly" };

        br = 0;
        var itemsFaker = new Faker<Item>()
            .RuleFor(i => i.Description, f => f.Lorem.Sentence())
            .RuleForType(typeof(int), f => f.Random.Number(10, 50))
            .RuleFor(i => i.Name, f => f.PickRandom(itemName));

        Items = itemsFaker.GenerateBetween(5, 5);

        var characterFaker = new Faker<Character>()
            .RuleFor(c => c.Name, f => (f.Name.FirstName() + "The" + f.Name.JobTitle()).Trim())
            .RuleForType(typeof(int), f => f.Random.Number(10, 50))
            .RuleFor(c => c.Health, f => f.Random.Number(800, 1300))
            .RuleFor(c => c.Mana, f => f.Random.Number(100, 500))
            .RuleFor(c => c.ClassId, f => f.PickRandom(Classes).Id);

        Characters = characterFaker.GenerateBetween(5, 5);

        for (int i = 0; i < 5; i++)
        {
            Items[i].CharacterId = Characters[i].Id;
        }
    }
}
