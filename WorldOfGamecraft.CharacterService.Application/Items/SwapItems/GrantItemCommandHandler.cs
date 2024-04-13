using MediatR;
using WorldOfGamecraft.CharacterService.Domain.Items;
using WorldOfGamecraft.Common.Data;
using WorldOfGamecraft.Common.Data.Cache;

namespace WorldOfGamecraft.CharacterService.Application.Items.SwapItems;
public sealed class GrantItemCommandHandler : IRequestHandler<GrantItemCommand>
{
    private readonly IItemRepository _itemRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRedisCache _cache;

    public GrantItemCommandHandler(IItemRepository itemRepository, IUnitOfWork unitOfWork, IRedisCache cache)
    {
        _itemRepository = itemRepository;
        _unitOfWork = unitOfWork;
        _cache = cache;
    }

    public async Task Handle(GrantItemCommand request, CancellationToken cancellationToken)
    {
        var item = await _itemRepository.GetByIdAsync(request.ItemId, cancellationToken);

        item.CharacterId = request.CharacterId;

        _itemRepository.Update(item);
        await _unitOfWork.SaveChangesAsync();

        await _cache.Invalidate(request.CharacterId, cancellationToken);
    }

}
