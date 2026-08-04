namespace Day33_LINQ_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>()
            {
                new Employee {Id=1, Name = "Amit", Department="IT", Salary=110000,Age=28,IsActive=true},
                new Employee {Id=2, Name = "Ravi", Department="HR", Salary=45000,Age=32,IsActive=true},
                new Employee {Id=3, Name = "Neha", Department="IT", Salary=75000,Age=30,IsActive=false},
                new Employee {Id=4, Name = "Sneha", Department="Finance", Salary=80000,Age=35,IsActive=true},
                new Employee {Id=5, Name = "Arjun", Department="IT", Salary=50000,Age=26,IsActive=true}
            };

            // 1- Get ALl active employees from IT Department
            var result = employees
                         .Where(e=>e.IsActive==true && e.Department=="IT")
                         .ToList();

            foreach (var item in result)
            {
                Console.WriteLine("Name : " + item.Name +"Dept "+ item.Department +"Active  "+ item.IsActive);
            }

            //2. Get Highest Salary employee

            var result1 = employees
                          .OrderByDescending(e => e.Salary)
                          .First();
            Console.WriteLine(result1.Name + result1.Salary);


            //3.Group employees by department and count

            var result2 = employees
                          .GroupBy(e => e.Department)
                          .Select(
                                g => new
                                {
                                    Department = g.Key,
                                    Count = g.Count(),
                                }
                            ).ToList();
            foreach (var item in result2)
            {
                Console.WriteLine("Department " +item.Department + "  Count of Employees : " +item.Count);
            }

            //4 . Check if any employee salary >1 Lakh

            var result3 = employees
                          .Where(e => e.Salary>100000)
                          .ToList();
            foreach (var item in result3)
            {
                Console.WriteLine(item.Name);
            }


            // 5. Get Employees between age 25-30 sort them by salary

            var result4 = employees
                          .Where(e=>e.Age>=25 &&  e.Age<=30)
                          .OrderByDescending (e => e.Salary)
                          .ToList();
            foreach (var item in result4)
            {
                Console.WriteLine(item.Name + item.Age);
            }

            // 6. Get second highest salary of employee
            if(!int.TryParse(Console.ReadLine(),out int n))
            {
                Console.WriteLine("Please enter positive integer input");
            }
            var result5 = employees
                          .OrderByDescending(e => e.Salary)
                          .Skip(n)
                          .Take(1)
                          .ToList();
            foreach (var item in result5)
            {
                Console.WriteLine(item.Salary  + item.Name) ;
            }


            // Get the highest salary in every department
            var result6 = employees                          
                          .GroupBy(e => e.Department)
                          
                          .Select(
                                g => new
                                {
                                    Department = g.Key,
                                    HighestSalary = g.Max(g=>g.Salary)
                                }
                            );
            foreach (var item in result6)
            {
                Console.WriteLine(item.Department    +  item.HighestSalary) ;
            }


        }
    }
}
