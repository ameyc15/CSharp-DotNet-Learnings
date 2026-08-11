using Day37_EFCore_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Day37_EFCore_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dept = new Department
            {
                DepartmentName = "IT"
            };
            
            AppDbContext db = new AppDbContext();
            db.Departments.Add(dept);
            db.SaveChanges();

            var emp1 = new Employee
            {
                Name = "Sachin",
                DepartmentId = 1
            };

            var emp2 = new Employee
            {
                Name = "Amey",
                DepartmentId = 1
            };
            db.Employees.AddRange(emp1,emp2);
            db.SaveChanges();

            var emp = db.Employees.Include(e => e.department).ToList();

            foreach (var item in emp)
            {
                Console.WriteLine("Employee : " + item.Name + "with Id " + item.Id + "Department : " +item.DepartmentId) ;
            }
        }
    }
}
