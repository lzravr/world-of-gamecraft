using MediatR;
using WorldOfGamecraft.CharacterService.Domain.Characters;

namespace WorldOfGamecraft.CharacterService.Application.Characters.GetCharacters;
public sealed record GetCharacterByIdQuery(Guid Id, string OwnerUsername) : IRequest<CharacterDetailsResponse?>;
