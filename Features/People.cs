namespace MyConsoleApp.Features;

// record classes
public record OneTypePerson(string FirstName, string LastName); // Positional parameters, overrides Equals and GeHashCode and provides decosntruction

public record SecondTypePerson
{
    // The FirstName and LastName properties are explicitly declared inside the record.
    public required string FirstName { get; set; } 
    public required string LastName { get; init; }  // The init accessor makes the properties immutable after the object is initialized.
                                                    // required keyword indicates that these properties must be provided during initialization.
};


