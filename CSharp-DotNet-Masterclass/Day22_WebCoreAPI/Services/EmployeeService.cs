using Day22_WebCoreAPI.Repositories;

namespace Day22_WebCoreAPI.Services
{
    public class EmployeeService
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();
        public EmployeeService() { }

        public string GetEmployeeData()
        {
            return employeeRepository.GetEmployeeData();
        }
    }
}
