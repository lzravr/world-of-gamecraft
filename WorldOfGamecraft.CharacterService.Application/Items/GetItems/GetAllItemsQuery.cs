using MediatR;

namespace WorldOfGamecraft.CharacterService.Application.Items.GetItems;
public sealed record GetAllItemsQuery() : IRequest<List<ItemResponse>>;
