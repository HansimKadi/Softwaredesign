namespace App.Entities;

public class Student
{
    public int Id { get; set; } // PK by name
    public string Name { get; set; } = string.Empty; // can ? or empty string to not get null warning

    public int EducationId { get; set; } // FK by name convention
    public Education? Education { get; set; } // navigation property

    public override string ToString()
    {
        return $"Student: {Name}, EducationId: {EducationId}";
    }
}
