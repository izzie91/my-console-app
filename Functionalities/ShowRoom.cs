using MyConsoleApp.Features;

namespace MyConsoleApp.ShowRoom;

public class ShowRoom
{
    private OneTypePerson _personOne = new OneTypePerson("John", "Snow");
    private SecondTypePerson _personTwo = new SecondTypePerson { FirstName = "Ron", LastName = "Weasley" }; // there is not primary constructor

    public void DisplayPeople()
    {
        (string name, string lastName) = _personOne;
        Console.WriteLine($"Person One: {name} {lastName}");
        
        Console.WriteLine($"Person Two: {_personTwo.FirstName} {_personTwo.LastName}"); // there is not primary constructor
        _personTwo.FirstName = "Ginny"; // can modify property 'cuz it is not init
        Console.WriteLine($"Person Two After: {_personTwo.FirstName} {_personTwo.LastName}");
        Console.WriteLine(_personOne.GetHashCode());
    }
}
