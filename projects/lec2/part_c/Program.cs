using System;

namespace part_c // project name
{
    internal class Program
    {
        static void Main()
        {
            Person person = new("James", "Karington");
            //person.FirstName = "James"; // Do not need to be set since we have the constructor
            //person.LastName = "Karington"; // same as above
            person.Age = 24;

            Console.WriteLine($"His last name is {person.LastName}, he is {person.Age} and is currently {person.Occupation}");
        }
    }
}
