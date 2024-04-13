using AutoMapper;
using MediatR;
using WorldOfGamecraft.CharacterService.Domain.Items;

namespace WorldOfGamecraft.CharacterService.Application.Items.GetItems;
public class GetItemByIdQueryHandler : IRequestHandler<GetItemByIdQuery, ItemResponse>
{
    private readonly IItemRepository _itemRepository;
    private readonly IMapper _mapper;

    public GetItemByIdQueryHandler(IItemRepository itemRepository, IMapper mapper)
    {
        _itemRepository = itemRepository;
        _mapper = mapper;
    }

    public async Task<ItemResponse> Handle(GetItemByIdQuery request, CancellationToken cancellationToken)
    {
        var item = await _itemRepository.GetByIdAsync(request.id, cancellationToken);

        if (item is null)
        {
            throw new ItemDoesNotExistException();
        }

        return _mapper.Map<ItemResponse>(item);
    }
}
