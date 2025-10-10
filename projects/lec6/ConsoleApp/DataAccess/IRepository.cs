using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Model; // Importing the Model namespace to use the User class 

namespace ConsoleApp.DataAccess // Defining the DataAccess namespace its telling where this interface is located
{
    public interface IRepository // Defining the IRepository interface an interface is a contract that defines methods that must be implemented by any class that implements this interface  
    {                            // An interface is for a method what a class is for an object.
        List<User> ReadAllUsers(); // Method signature for reading all users, returns a list of User objects
    }

}

