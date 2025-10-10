using ConsoleApp.BusinessLogic; // Importing BusinessLogic namespace soo we can use UserHandler
using ConsoleApp.DataAccess; // Importing DataAccess namespace soo we can use SqliteRepository and IRepository and or JsonRepository

namespace ConsoleApp // Defining the namespace for the console application
{
    internal class Program // Defining the Program class
    {
        static void Main(string[] args) // Main method - entry point of the application 
        {
            UserHandler userHandler = new(new SqliteRepository()); // Creating an instance of UserHandler with SqliteRepository
            // UserHandler userHandler = new(new JsonRepository()); // Creating an instance of UserHandler with JsonRepository

            userHandler.PrintAllUsers(); // Calling PrintAllUsers method to display all users
        }
    }
}
