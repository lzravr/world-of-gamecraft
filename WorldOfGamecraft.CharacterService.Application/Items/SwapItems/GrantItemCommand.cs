using MediatR;

namespace WorldOfGamecraft.CharacterService.Application.Items.SwapItems;
public sealed record GrantItemCommand(Guid ItemId, Guid CharacterId) : IRequest;
