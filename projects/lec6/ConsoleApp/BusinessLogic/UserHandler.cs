using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Model;
using ConsoleApp.DataAccess;


namespace ConsoleApp.BusinessLogic // Defining the BusinessLogic namespace its telling where this class is located
{
    public class UserHandler // Defining the UserHandler class
    {
        private IRepository _repository; // Private field to hold the repository instance

        public UserHandler(IRepository repository) // Constructor that takes an IRepository instance
        {
            _repository = repository; // Assigning the passed repository to the private field
        }


        public void PrintAllUsers() // Method to print all users
        {
            List<User> userList = _repository.ReadAllUsers(); // Reading all users from the repository

            foreach (User user in userList) // Iterating through the list of users
            {
                Console.WriteLine(user); // Printing each user to the console
            }
        }
    }
}

