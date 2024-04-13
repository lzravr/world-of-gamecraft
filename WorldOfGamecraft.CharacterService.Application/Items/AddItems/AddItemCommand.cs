using MediatR;

namespace WorldOfGamecraft.CharacterService.Application.Items.AddItems;
public sealed record AddItemCommand(string Name, string Description, int BonusStrength, int BonusAgility, int BonusInteligence, int BonusFaith) : IRequest<Guid>;
