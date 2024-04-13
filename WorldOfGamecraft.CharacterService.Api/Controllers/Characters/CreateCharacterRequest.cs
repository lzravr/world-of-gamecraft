namespace WorldOfGamecraft.CharacterService.Api.Controllers.Characters;

public sealed record CreateCharacterRequest(string Name, int Health, int Mana, string ClassName, int Strength, int Agility, int Inteligence, int Faith);
