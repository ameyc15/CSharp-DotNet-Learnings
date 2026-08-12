using Day38_EF_SampleApplication.Data;
using Day38_EF_SampleApplication.Models;

namespace Day38_EF_SampleApplication.Repository
{
    public class EmployeeRepository :IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository() 
        {

        }

        public IEnumerable<Employee> GetAll()
        {

        }
        public Employee GetById(int id) 
        {

        }
        public void Add(Employee employee) 
        {

        }
    }
}
