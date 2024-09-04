namespace MyConsoleApp.Features.Messages;

public class SMSMessage : IBaseMessage
{
    private const string _message = "This is an SMS message";

    public string Message() => _message;  
}
