using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp.Model // Defining the Model namespace its telling where this class is located
{
    public class User // Defining the User class
    {
        public int Id { get; set; } // Property for the user's ID
        public string Name { get; set; } = string.Empty; // Property for the user's name

        //public string Email { get; set; }
        //public string Password { get; set; }

        public override string ToString() // Overriding the ToString method to provide a custom string representation of the User object 
        { // we have to do this if we want to print the object directly or in a readable format
            return $"{Id}, {Name}"; // Returning a string that includes the user's ID and name
        }
    }
}
