namespace MyConsoleApp.Computing;

public class Computing
{
    private static Computing _instance = null;
    private Computing() { }

    private delegate int MyOperation(int a, int b);
    private int Add(int a, int b) => a + b;
    private int Sub(int a, int b) => a - b;
    private int Mult(int a, int b) => a * b;
    private int Div(int a, int b) => a / b;

    public static Computing getInstance()
    {
        if (_instance == null)
        {
            _instance = new Computing();
        }
        return _instance;
    }    

    public void Calculate(string operation, int a, int b)
    {
        MyOperation func = Add;     

        func = operation switch
        {
            "Sub" => Sub,
            "Mult" => Mult,
            "Div" => Div,
            _ => Add
        };

        Console.WriteLine(func(a, b) + "\n");
    }

}
