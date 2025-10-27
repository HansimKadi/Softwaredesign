namespace App.Entities;

public class Education
{
    public int Id { get; set; } // PK by name
    public string Name { get; set; } = string.Empty; // can ? or empty string to not get null warning

    public ICollection<Student>? Students { get; set; } // navigation property
}
