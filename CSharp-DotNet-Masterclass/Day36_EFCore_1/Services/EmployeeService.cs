using Day36_EFCore_1.Models;
using Day36_EFCore_1.Repositories;

namespace Day36_EFCore_1.Services
{
    public class EmployeeService
    {
        private readonly EmployeeReposiotory _employeeRepository;
        public EmployeeService(EmployeeReposiotory employeeReposiotory) 
        {
            _employeeRepository = employeeReposiotory;
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return List<Employee>;
        }
    }
}
