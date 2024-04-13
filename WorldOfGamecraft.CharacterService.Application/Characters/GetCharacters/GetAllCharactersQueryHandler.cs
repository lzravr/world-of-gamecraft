using AutoMapper;
using MediatR;
using WorldOfGamecraft.CharacterService.Domain.Characters;
using WorldOfGamecraft.Common.Data;

namespace WorldOfGamecraft.CharacterService.Application.Characters.GetCharacters;
public sealed class GetAllCharactersQueryHandler : IRequestHandler<GetAllCharactersQuery, List<CharacterResponse>>
{
    private readonly ICharacterRepository _characterRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllCharactersQueryHandler(IUnitOfWork unitOfWork, ICharacterRepository characterRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _characterRepository = characterRepository;
        _mapper = mapper;
    }

    public async Task<List<CharacterResponse>> Handle(GetAllCharactersQuery request, CancellationToken cancellationToken)
    {
        return _mapper.Map<List<Character>, List<CharacterResponse>>(await _characterRepository.GetAllAsync(cancellationToken));
    }
}
