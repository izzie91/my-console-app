namespace MyConsoleApp.Functionalities;

public class Functionalities
{
    private static Functionalities _instance = null;
    private Functionalities() { }

    public static Functionalities getInstance()
    {
        if (_instance == null)
        {
            _instance = new Functionalities();
        }
        return _instance;
    }

    public string EditText(string text, int number)
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

    public string OtherEditText(string text, int number)
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
