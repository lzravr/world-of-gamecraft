using AutoMapper;
using MediatR;
using Newtonsoft.Json;
using WorldOfGamecraft.CharacterService.Domain.Characters;
using WorldOfGamecraft.Common;
using WorldOfGamecraft.Common.Data.Cache;
using WorldOfGamecraft.Common.IdentityService;

namespace WorldOfGamecraft.CharacterService.Application.Characters.GetCharacters;
public sealed class GetCharacterByIdQueryHandler : IRequestHandler<GetCharacterByIdQuery, CharacterDetailsResponse?>
{
    private readonly ICharacterRepository _characterRepository;
    private readonly IMapper _mapper;
    private readonly IIdentityServiceClient _identityServiceClient;
    private readonly IRedisCache _cache;

    public GetCharacterByIdQueryHandler(ICharacterRepository characterRepository, IMapper mapper, IIdentityServiceClient identityServiceClient, IRedisCache cache)
    {
        _characterRepository = characterRepository;
        _mapper = mapper;
        _identityServiceClient = identityServiceClient;
        _cache = cache;
    }

    public async Task<CharacterDetailsResponse?> Handle(GetCharacterByIdQuery request, CancellationToken cancellationToken)
    {
        string? accountId = null;

        if (request.Role.Equals(Role.User.ToString()))
        {
            accountId = await _identityServiceClient.GetAccountIdByUsername(request.OwnerUsername, cancellationToken);
        }

        // try to get cached
        var characterJson = await _cache.GetAsync(request.Id, cancellationToken);

        if (characterJson is not null)
        {
            return JsonConvert.DeserializeObject<CharacterDetailsResponse>(characterJson);
        }

        var character = await _characterRepository.GetByIdAsync(request.Id, cancellationToken);

        if (character is null)
        {
            throw new CharacterDoesNotExistException();
        }

        if (accountId is not null && !accountId.Equals(character?.CreatedBy.ToString()))
        {
            throw new NotCharacterOwnerException();
        }

        CalculateStats(character);

        var result = _mapper.Map<Character?, CharacterDetailsResponse?>(character);
        await _cache.SetAsync(character.Id, JsonConvert.SerializeObject(result), cancellationToken);

        return result;
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
