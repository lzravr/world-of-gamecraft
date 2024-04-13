using MediatR;

namespace WorldOfGamecraft.CharacterService.Application.Items.GetItems;
public sealed record GetItemByIdQuery(Guid id) : IRequest<ItemResponse>;
