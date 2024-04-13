using AutoMapper;
using MediatR;
using WorldOfGamecraft.CharacterService.Domain.Characters;
using WorldOfGamecraft.Common.Data;
using WorldOfGamecraft.Common.IdentityService;

namespace WorldOfGamecraft.CharacterService.Application.Characters.GetCharacters;
public sealed class GetCharacterByIdQueryHandler : IRequestHandler<GetCharacterByIdQuery, CharacterDetailsResponse?>
{
    private readonly ICharacterRepository _characterRepository;
    private readonly IMapper _mapper;
    private readonly IIdentityServiceClient _identityServiceClient;

    public GetCharacterByIdQueryHandler(ICharacterRepository characterRepository, IMapper mapper, IIdentityServiceClient identityServiceClient)
    {
        _characterRepository = characterRepository;
        _mapper = mapper;
        _identityServiceClient = identityServiceClient;
    }

    public async Task<CharacterDetailsResponse?> Handle(GetCharacterByIdQuery request, CancellationToken cancellationToken)
    {
        var accountId = await _identityServiceClient.GetAccountIdByUsername(request.OwnerUsername, cancellationToken);

        var character = await _characterRepository.GetByIdAsync(request.Id, cancellationToken);

        if (!accountId.Equals(character?.CreatedBy.ToString()))
        {
            throw new NotCharacterOwnerException();
        }

        if (character is not null)
            CalculateStats(character);

        return _mapper.Map<Character?, CharacterDetailsResponse?>(character);
    }

    private void CalculateStats(Character character)
    {
        foreach (var item in character.Items)
        {
            character.BaseStrength += item.BonusStrength;
            character.BaseAgility += item.BonusAgility;
            character.BaseIntelligence += item.BonusIntelligence;
            character.BaseFaith += item.BonusFaith;
        }
    }
}
