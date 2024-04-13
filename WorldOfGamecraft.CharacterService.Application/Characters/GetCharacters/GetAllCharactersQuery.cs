using MediatR;

namespace WorldOfGamecraft.CharacterService.Application.Characters.GetCharacters;
public sealed record GetAllCharactersQuery() : IRequest<List<CharacterResponse>>;
