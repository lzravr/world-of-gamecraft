namespace WorldOfGamecraft.CharacterService.Api.Controllers.Items;

public sealed record GrantItemRequest(Guid ItemId, Guid CharacterId);