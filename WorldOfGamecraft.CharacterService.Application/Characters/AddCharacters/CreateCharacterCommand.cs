using MediatR;

namespace WorldOfGamecraft.CharacterService.Application.Characters.AddCharacters;
public sealed record CreateCharacterCommand(string Name,int Health, int Mana, string ClassName, int Strength, int Agility, int Inteligence, int Faith, string ownerUsername) : IRequest<Guid>;
