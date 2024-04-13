using AutoMapper;
using MediatR;
using WorldOfGamecraft.CharacterService.Domain.Items;

namespace WorldOfGamecraft.CharacterService.Application.Items.GetItems;
public sealed class GetAllItemsQueryHandler : IRequestHandler<GetAllItemsQuery, List<ItemResponse>>
{
    private readonly IItemRepository _itemRepository;
    private readonly IMapper _mapper;

    public GetAllItemsQueryHandler(IItemRepository itemRepository, IMapper mapper)
    {
        _itemRepository = itemRepository;
        _mapper = mapper;
    }

    public async Task<List<ItemResponse>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
    {
        var items = await _itemRepository.GetAllAsync(cancellationToken);

        return _mapper.Map<List<Item>, List<ItemResponse>>(items);
    }
}
