using MyConsoleApp.Enums;

namespace MyConsoleApp.Features;

public class Employee
{    
    private Guid _guid = Guid.NewGuid();
    private string _name;
    private string _lastName;
    private readonly string _role = ROLES.CLIENT;
    private const COUNTRIES _country = COUNTRIES.Cuba;

    public Employee(string name, string lastName, string role = "")
    {
        _name = name;
        _lastName = lastName;
        if (string.IsNullOrEmpty(role))
            _role = role;
    }

    public Guid Guid
    {
        get { return _guid; }
        set { _guid = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public string Role
    {
        get { return _role; } // Only a getter because _role is readonly
    }

    public COUNTRIES Country
    {
        get { return _country; } // Only a getter because _country is const
    }
}
