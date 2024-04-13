using System.Runtime.Serialization;

namespace WorldOfGamecraft.CharacterService.Application.Characters.AddCharacters;
[Serializable]
internal class ClassDoesNotExistException : Exception
{
    public ClassDoesNotExistException()
    {
    }

    public ClassDoesNotExistException(string? message) : base(message)
    {
    }

    public ClassDoesNotExistException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected ClassDoesNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}