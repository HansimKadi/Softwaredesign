using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Model; // Importing the Model namespace to use the User class

namespace ConsoleApp.DataAccess // Defining the DataAccess namespace its telling where this class is located
{
    public class JsonRepository : IRepository // Defining the JsonRepository class that implements the IRepository interface
    {
        public List<User> ReadAllUsers() // Implementing the ReadAllUsers method from the IRepository interface
        {   // In a real-world scenario, this method would read from a JSON file or database. Here, we are simulating it with hardcoded data.
            List<User> users = new() { // Creating a list of User objects.
                new User() { Id = 1, Name = "Hetti" },
                new User() { Id = 2, Name = "Letti" },
                new User() { Id = 3, Name = "Netti" },
            };

            return users; // Returning the list of users
        }
    }

}

