
namespace MyConsoleApp;

internal class Program
{    
    static void Main(string[] args)
    {
        //Ummutable strings

        string firstString = "My first string";

        System.String secondString = "My second string";

        // only used new when string is created from an array of chars
        char[] myArray = { 'I', 's', 'a', 'b', 'e', 'l' };
        var thirdString = new string(myArray);

        Console.WriteLine("Example One: " + firstString);
        Console.WriteLine("Example Two: " + secondString);
        Console.WriteLine("Example Two: " + thirdString);

        Console.WriteLine("\n");

        // Quoted strings -> are string values defined on one line in code that start with a single double quote character and end with a single double quote character
        string quotedString = "\"C:\\development\\CSharpProjects\"";
        Console.WriteLine(quotedString);

        //Verbatim string literals -> quotations and backslash characters need to be included in the output for string literals.
        // Easier and cleaner
        string path = @"""C:\development\CSharpProjects""";
        Console.WriteLine(path);

        // Multiline text
        string narrative = 
            @"Humpty Dumpty sat on the wall
                Humpty Dumpty had a great fall
                all the kings horses and all the kings men
                couldn’t put Humpty together again";                 
        Console.WriteLine(narrative);

        // multiline with raw string literals C#11 release
        string text = """
                "To be or not to be" is a quote from Shakespeare's Hamlet.
                "To be or not to be" is a quote from Shakespeare's Hamlet.
                """;
        Console.WriteLine(text);

        // my functionalities with Singleton pattern
        var funcionalities = Functionalities.getInstance();

        Console.WriteLine(funcionalities.EditText("8 manzanas rojas", 3));
    }
}
