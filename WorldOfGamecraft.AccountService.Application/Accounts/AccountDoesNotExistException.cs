using System.Runtime.Serialization;

namespace WorldOfGamecraft.AccountService.Application.Accounts;
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