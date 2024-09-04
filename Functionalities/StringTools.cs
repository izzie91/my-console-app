namespace MyConsoleApp.Functionalities;

public class StringTools
{
    private static StringTools _instance = null;
    private StringTools() { }

    public static StringTools getInstance()
    {
        if (_instance == null)
        {
            _instance = new StringTools();
        }
        return _instance;
    }

    public string ReplaceNumberInString(string text, int number)
    {
        string[] substrings = text.Split(' ');
        substrings[0] = number.ToString();
        var myNewString = string.Empty;
        foreach (string s in substrings)
        {
            myNewString += s + " ";
        }

        return myNewString.TrimEnd();
    }

    public string OtherReplaceNumberInString(string text, int number)
    {
        string[] substrings = text.Split(' ');
        substrings[0] = number.ToString();
        string myNewString = string.Empty;

        foreach (string s in substrings)
        {
            myNewString = string.Concat([myNewString, s, " "]);
        }

        return myNewString.TrimEnd();
    }

    public void IterateOverString(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i] + "\n");
        }
    }
}
