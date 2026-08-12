using Day38_EF_SampleApplication.Data;
using Day38_EF_SampleApplication.Models;

namespace Day38_EF_SampleApplication.Repository
{
    public class EmployeeRepository :IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext appDbContext) 
        {
            _context = appDbContext;
        }

        public IEnumerable<Employee> GetAll()
        {
            var employees = _context.Employees.ToList();
            return employees;
        }
        public Employee GetById(int id) 
        {
            return _context.Employees.Find(id);
        }
        public void Add(Employee employee) 
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
    }
}
