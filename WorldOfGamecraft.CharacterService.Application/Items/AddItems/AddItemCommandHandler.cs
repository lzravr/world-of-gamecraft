using MediatR;
using WorldOfGamecraft.CharacterService.Domain.Items;
using WorldOfGamecraft.Common.Data;

namespace WorldOfGamecraft.CharacterService.Application.Items.AddItems;
public sealed class AddItemCommandHandler : IRequestHandler<AddItemCommand, Guid>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IItemRepository _itemRepository;

    public AddItemCommandHandler(IUnitOfWork unitOfWork, IItemRepository itemRepository)
    {
        _unitOfWork = unitOfWork;
        _itemRepository = itemRepository;
    }

    public async Task<Guid> Handle(AddItemCommand request, CancellationToken cancellationToken)
    {
        var item = Item.Create(
            request.Name,
            request.Description,
            request.BonusStrength,
            request.BonusAgility,
            request.BonusInteligence,
            request.BonusFaith);

        _itemRepository.Add(item);
        await _unitOfWork.SaveChangesAsync();

        return item.Id;
    }
}
