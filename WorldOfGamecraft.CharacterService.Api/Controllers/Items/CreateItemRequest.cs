namespace WorldOfGamecraft.CharacterService.Api.Controllers.Items;

public sealed record CreateItemRequest(string Name, string Description, int BonusStrength, int BonusAgility, int BonusInteligence, int BonusFaith);