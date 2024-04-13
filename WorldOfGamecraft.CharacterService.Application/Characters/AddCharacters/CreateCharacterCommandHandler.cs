using MediatR;
using WorldOfGamecraft.CharacterService.Domain.CharacterClasses;
using WorldOfGamecraft.CharacterService.Domain.Characters;
using WorldOfGamecraft.Common.Data;
using WorldOfGamecraft.Common.IdentityService;

namespace WorldOfGamecraft.CharacterService.Application.Characters.AddCharacters;
public sealed class CreateCharacterCommandHandler : IRequestHandler<CreateCharacterCommand, Guid>
{
    private readonly ICharacterRepository _characterRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IClassRepository _classRepository;
    private readonly IIdentityServiceClient _identityServiceClient;

    public CreateCharacterCommandHandler(IUnitOfWork unitOfWork, ICharacterRepository characterRepository, IClassRepository classRepository, IIdentityServiceClient identityServiceClient)
    {
        _unitOfWork = unitOfWork;
        _characterRepository = characterRepository;
        _classRepository = classRepository;
        _identityServiceClient = identityServiceClient;
    }

    public async Task<Guid> Handle(CreateCharacterCommand request, CancellationToken cancellationToken)
    {
        var @class = await _classRepository.GetByNameAsync(request.ClassName, cancellationToken);

        if (@class is null)
        {
            throw new ClassDoesNotExistException();
        }

        var accountId = await _identityServiceClient.GetAccountIdByUsername(request.ownerUsername, cancellationToken);

        var character = Character.Create(
            request.Name,
            request.Health,
            request.Mana,
            request.Strength,
            request.Agility,
            request.Inteligence,
            request.Faith,
            @class.Id,
            new Guid(accountId)
            );

        _characterRepository.Add(character);
        await _unitOfWork.SaveChangesAsync();

        return character.Id;
    }
}
