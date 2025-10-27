using System.Collections.Generic;
namespace without_DIDP;
// Service class or dependency object 
// This is the class that is responsible for interaction with the database
// This class is going to be used by the EmployeeBL class
// That means it is  going to be the dependency object 

public class EmployeeDAL
{
    public List<Employee> SelectAllEmployees()
    {
        List<Employee> ListOfEmployees = new List<Employee>()
    {
      // get the employee data from the database
      // for now we are hard coding the data
      new Employee() { ID = 1, Name = "John", Department = "IT" },
      new Employee() { ID = 2, Name = "Jane", Department = "HR" },
      new Employee() { ID = 3, Name = "Sam", Department = "Finance" }

    };
        return ListOfEmployees;
    }
}
