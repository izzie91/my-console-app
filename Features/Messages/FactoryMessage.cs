namespace MyConsoleApp.Features.Messages;

public class FactoryMessage
{
    private string _messageType = string.Empty;

    public FactoryMessage(string messageType = "sms")
    {
        _messageType = messageType;
    }

    private IBaseMessage FactoryMethod()
    {
        IBaseMessage display = _messageType switch
        {
            "email" => new EmailMessage(),
            "sms" => new SMSMessage(),
            _ => new SMSMessage(),
        }; 

        return display;
    }

    public void DisplayMessage()
    {
        Console.WriteLine(FactoryMethod().Message());
    }
}
