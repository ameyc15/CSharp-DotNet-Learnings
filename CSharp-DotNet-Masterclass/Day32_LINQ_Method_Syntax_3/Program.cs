namespace Day32_LINQ_Method_Syntax_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
           {
               new Employee
            {
                Id = 1,Name = "Aarav Sharma",Department = "IT", City = "Pune", Salary = 95000
            },
            new Employee
            {
                Id = 2,Name = "Priya Deshmukh",Department = "HR",City = "Mumbai", Salary = 65000
            },
            new Employee
            {
                Id = 3,Name = "Rohan Verma",Department = "IT",City = "Bengaluru",Salary = 120000
            },
            new Employee
            {
                Id = 4,Name = "Ananya Iyer",Department = "Finance",City = "Pune",Salary = 82000
            },
            new Employee
            {
                Id = 5,Name = "Vikram Patil",Department = "Marketing",City = "Pune",Salary = 75000
            },
            new Employee
            {
                Id = 6,Name = "Sneha Kulkarni", Department = "IT",City = "Hyderabad", Salary = 110000
            }
           };

            // filter employees with IT department
            var itdept = employees.Where(e => e.Department == "IT").ToList();
            foreach (var item in itdept)
            {
                Console.WriteLine("Name " + item.Name + "Department " + item.Department);
            }



            // filter employees whose salary is > 100000
            var filterSal = employees.Where(e => e.Salary > 100000).ToList();
            foreach (var item in filterSal)
            {
                Console.WriteLine(item.Name + item.Salary);
            }

            // sort employees by salary high to low 
            Console.WriteLine("**********************Third Query*********************");
            var sortedSal = employees.OrderByDescending(e => e.Salary).ToList();
            foreach (var item in sortedSal)
            {
                Console.WriteLine(item.Name + item.Salary);
            }


            // Sort by department then sort by Salary descending
            Console.WriteLine("****************************4th Question****************************");
            var result = employees
                         .OrderByDescending(e => e.Department)
                         .ThenByDescending(e => e.Salary)
                         .ToList();
            foreach (var item in result)
            {
                Console.WriteLine("Name " + item.Name + " Salary " +item.Salary + " Department " +item.Department);
            }

            // Group by the department 
            Console.WriteLine("****************************5th Question****************************");
            var result1 = employees
                          .GroupBy(e => e.Department)
                          .Select
                          (
                                g=> new
                                {
                                    Department = g.Key,
                                    Count = g.Count()
                                }
                          ).ToList();
            foreach (var grp in result1)
            {
                Console.WriteLine("Department : " + grp.Department + "Count of Employees  " + grp.Count);
            }


        }
    }
}
