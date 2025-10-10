using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Model; // Importing the Model namespace to use the User class



namespace ConsoleApp.DataAccess // Defining the DataAccess namespace its telling where this class is located
{
    public class SqliteRepository : IRepository // Defining the SqliteRepository class that implements the IRepository interface
    {
        public List<User> ReadAllUsers() // Implementing the ReadAllUsers method from the IRepository interface
        {
            List<User> users = new() // Creating a list of User objects.
      {
        new User() { Id = 10, Name = "Rollo" },
        new User() { Id = 20, Name = "Tomasi" },
      };

            return users; // Returning the list of users
        }


    }
}

