using System.Runtime.Serialization;

namespace WorldOfGamecraft.CharacterService.Application.Characters.GetCharacters;
[Serializable]
internal class NotCharacterOwnerException : Exception
{
    public NotCharacterOwnerException()
    {
    }

    public NotCharacterOwnerException(string? message) : base(message)
    {
    }

    public NotCharacterOwnerException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NotCharacterOwnerException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}