using System.Runtime.Serialization;

namespace WorldOfGamecraft.CharacterService.Application.Characters.AddCharacters;
[Serializable]
internal class AccountDoesNotExistException : Exception
{
    public AccountDoesNotExistException()
    {
    }

    public AccountDoesNotExistException(string? message) : base(message)
    {
    }

    public AccountDoesNotExistException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected AccountDoesNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}