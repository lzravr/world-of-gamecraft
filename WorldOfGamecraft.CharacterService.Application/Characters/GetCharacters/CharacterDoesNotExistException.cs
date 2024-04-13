using System.Runtime.Serialization;

namespace WorldOfGamecraft.CharacterService.Application.Characters.GetCharacters;
[Serializable]
internal class CharacterDoesNotExistException : Exception
{
    public CharacterDoesNotExistException()
    {
    }

    public CharacterDoesNotExistException(string? message) : base(message)
    {
    }

    public CharacterDoesNotExistException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected CharacterDoesNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}