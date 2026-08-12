using Day38_EF_SampleApplication.Models;

namespace Day38_EF_SampleApplication.Repository
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll();

        public Employee GetById(int id);

        public void Add(Employee entity);
    }
}
