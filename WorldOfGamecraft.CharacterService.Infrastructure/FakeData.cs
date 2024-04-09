using Bogus;
using WorldOfGamecraft.CharacterService.Domain.CharacterClasses;
using WorldOfGamecraft.CharacterService.Domain.Characters;
using WorldOfGamecraft.CharacterService.Domain.Items;

namespace WorldOfGamecraft.CharacterService.Infrastructure;
public static class FakeData
{
    public static List<Character> Characters { get; set; }
    public static List<Class> Classes { get; set; } = new();
    public static List<Item> Items { get; set; }

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
            .RuleFor(i => i.Name, f => itemName[br++])
            .RuleFor(i => i.Description, f => f.Lorem.Sentence())
            .RuleForType(typeof(int), f => f.Random.Number(10, 50));

        Items = itemsFaker.GenerateBetween(itemName.Length, itemName.Length);

        var characterFaker = new Faker<Character>()
            .RuleFor(c => c.Name, f => (f.Name.FirstName() + "The" + f.Name.JobTitle()).Trim())
            .RuleForType(typeof(int), f => f.Random.Number(10, 50))
            .RuleFor(c => c.Health, f => f.Random.Number(800, 1300))
            .RuleFor(c => c.Mana, f => f.Random.Number(100, 500))
            .RuleFor(c => c.ClassId, f => f.PickRandom(Classes).Id)
            .RuleFor(c => c.Items, (f, c) =>
            {
                itemsFaker.RuleFor(i => i.CharacterId, _ => c.Id);
                itemsFaker.RuleFor(i => i.Name, f => f.PickRandom(itemName));

                var items = itemsFaker.GenerateBetween(0, 3);

                Items.AddRange(items);

                return null;
            });

        Characters = characterFaker.GenerateBetween(5, 10);
    }
}
