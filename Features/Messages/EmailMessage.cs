namespace MyConsoleApp.Features.Messages;

public class EmailMessage : IBaseMessage
{
    private const string _message = "This is an Email message";

    public string Message() => _message;  
}
