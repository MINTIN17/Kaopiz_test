using System;
namespace MyApp.Domain.Exceptions;

public class EmailExistException : Exception
{
    public EmailExistException(string message) : base(message)
    {
    }
}
