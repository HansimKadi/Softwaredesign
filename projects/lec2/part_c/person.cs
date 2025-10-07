namespace part_c;

public class Person
{
    private string _firstName = "Undefined"; //private variable 
    private string _lastName = "Undefined"; // private variable
    private int _age;
    private string _occupation = "Unemployed";

    public string FirstName // property
    {
        get
        {
            Console.WriteLine($"First name: {_firstName}");
            return _firstName;
        } // get returns the variable
        set { _firstName = value; } // set sets the variable value, the value keyword represents what we assign the property
    }

    public string LastName // property
    {
        get
        {
            if (_lastName == "Undefined")
            {
                Console.WriteLine($"<last name not set>");
                return string.Empty;
            }
            else
            {
                Console.WriteLine($"Last name: {_lastName} ");
                return _lastName;
            }
        }
        set
        {
            _lastName = value.Trim();
        }
    }

    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            _age = value;
        }
    }

    public string Occupation
    {
        get
        {
            return _occupation;
        }
        set
        {
            _occupation = value;
        }
    }
    public string FullName
    {
        get
        {
            return _firstName + " " + _lastName;
        }
    }
    public Person(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }
}
