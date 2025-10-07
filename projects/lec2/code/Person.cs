namespace code;

public class Person
{
    public string Name { get; set; } = string.Empty; // removing this error

    private int _age;

    public int Age
    {
        get { return _age; }
        set
        {
            _age = value;

        }



    }



}



