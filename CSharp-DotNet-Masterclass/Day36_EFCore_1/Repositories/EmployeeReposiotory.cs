using Day36_EFCore_1.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Day36_EFCore_1.Repositories
{
    public class EmployeeReposiotory
    {
        private readonly AppDbContext _appDbContext;
        public EmployeeReposiotory(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _appDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _appDbContext.Employees.FindAsync(id);
        }

        public async Task AddAsync(Employee employee)
        {
           await _appDbContext.Employees.AddAsync(employee);
           await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var emp = await _appDbContext.Employees.FindAsync(id);

            if(emp != null)
            {
                _appDbContext.Employees.Remove(emp);
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Employee employee)
        {
            _appDbContext.Employees.Update(employee);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
