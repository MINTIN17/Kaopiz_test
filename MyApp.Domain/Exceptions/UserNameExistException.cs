namespace MyApp.Domain.Exceptions;

public class UserNameExistException : Exception
{
    public UserNameExistException(string message) : base(message)
    {
    }
}
