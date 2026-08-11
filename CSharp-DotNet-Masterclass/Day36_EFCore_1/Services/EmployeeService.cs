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
            return await _employeeRepository.GetAllAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _employeeRepository.GetByIdAsync(id);
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            await _employeeRepository.AddAsync(employee);
        }
         
        public async Task DeleteEmployeeById(int id)
        {
            await _employeeRepository.DeleteByIdAsync(id);
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            await _employeeRepository.UpdateAsync(employee);
        } 
    }
}
