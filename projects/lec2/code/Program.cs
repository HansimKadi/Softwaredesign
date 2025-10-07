using System;

namespace code
{
    internal class Program
    {
        static void Main()
        {
            Time time = new Time();

            time.Hours = 7.5;

            Console.WriteLine($"Time in hours: {time.Hours}");


            Person person = new();
            person.Name = "Tomas";
            person.Age = 51;

            Console.WriteLine($"Name: {person.Name} Age: {person.Age}");

        }

    }

}


