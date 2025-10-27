namespace with_DIDP;
// Client class or dependent object
// This is the class is going to consume the services provided by the IEmployeeDAL class
// That means it is the dependent class which is depending on the IEmployeeDAL class

public class EmployeeBL
{
    public IEmployeeDAL employeeDAL;
    // Injecting the dependecy object using constructor injection means it is a loose coupling
    public EmployeeBL(IEmployeeDAL employeeDAL)
    {
        this.employeeDAL = employeeDAL;
    }

    public List<Employee> GetAllEmployees()
    {
        return employeeDAL.SelectAllEmployees();
    }
}
