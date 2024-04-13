using MediatR;
using WorldOfGamecraft.CharacterService.Domain.Items;
using WorldOfGamecraft.Common.Data;

namespace WorldOfGamecraft.CharacterService.Application.Items.SwapItems;
public sealed class GrantItemCommandHandler : IRequestHandler<GrantItemCommand>
{
    private readonly IItemRepository _itemRepository;
    private readonly IUnitOfWork _unitOfWork;

    public GrantItemCommandHandler(IItemRepository itemRepository, IUnitOfWork unitOfWork)
    {
        _itemRepository = itemRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(GrantItemCommand request, CancellationToken cancellationToken)
    {
        var item = await _itemRepository.GetByIdAsync(request.ItemId, cancellationToken);

        item.CharacterId = request.CharacterId;

        _itemRepository.Update(item);
        await _unitOfWork.SaveChangesAsync();
    }

}
