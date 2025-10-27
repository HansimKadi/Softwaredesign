namespace without_DIDP;
// Client class or depedent object
// This is the class is going to consume the services provided by the EmployeeDAL class
// That means it is the dependent class which is depending on the employeeDAL class

public class EmployeeBL
{
    public EmployeeDAL employeeDAL;

    public List<Employee> GetAllEmployees()
    {
        // Creting an instance of dependency Class means it is a tight coupling
        employeeDAL = new EmployeeDAL();
        return employeeDAL.SelectAllEmployees();
    }

}
