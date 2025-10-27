using System;
using System.Collections.Generic;
namespace with_DIDP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of EmployeeBL and injecct the dependency object as an argument to the constructor
            EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
            List<Employee> Listemployee = employeeBL.GetAllEmployees();
            foreach (var emp in Listemployee)
            {
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}");
            }
        }
    }
}
