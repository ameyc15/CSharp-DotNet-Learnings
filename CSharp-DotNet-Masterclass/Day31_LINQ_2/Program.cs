namespace Day31_LINQ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Employee> employees = new List<Employee>()
           {
               new Employee
            {
                Id = 1,Name = "Aarav Sharma",Department = "Engineering", City = "Pune", Salary = 95000
            },
            new Employee
            {
                Id = 2,Name = "Priya Deshmukh",Department = "HR",City = "Mumbai", Salary = 65000
            },
            new Employee
            {
                Id = 3,Name = "Rohan Verma",Department = "Engineering",City = "Bengaluru",Salary = 120000
            },
            new Employee
            {
                Id = 4,Name = "Ananya Iyer",Department = "Finance",City = "Chennai",Salary = 82000
            },
            new Employee
            {
                Id = 5,Name = "Vikram Patil",Department = "Marketing",City = "Pune",Salary = 75000
            },
            new Employee
            {
                Id = 6,Name = "Sneha Kulkarni", Department = "Engineering",City = "Hyderabad", Salary = 110000
            }
           };

            // Find the employee with Highest Salary
            Console.WriteLine("***************1st LINQ*******************");

            var highestSalary = (from e in employees
                                orderby e.Salary descending
                                select e).Take(1);
            foreach (var item in highestSalary)
            {
                Console.WriteLine(item.Name + item.Salary);
            }


            // **** Find the employee with 2th highest salary
            Console.WriteLine("***************2nd LINQ*******************");
            var secondHighestSalary = (from e in employees
                                       orderby e.Salary descending
                                       select e).Skip(1).Take(1);
            foreach (var item in secondHighestSalary)
            {
                Console.WriteLine(item.Name + item.Salary);
            }


            //*** Find the employee with nth Highest Salary

            Console.WriteLine("***************3rd LINQ*******************");
            if(!int.TryParse(Console.ReadLine(),out int n))
            {
                Console.WriteLine("please enter the integer number as input");
            }

            var nthHighestSalary = (from e in employees
                                   orderby e.Salary descending
                                   select e).Skip(n-1).Take(1);
            foreach (var item in nthHighestSalary)
            {
                Console.WriteLine(item.Name + item.Salary);
            }

            // **********************Aggregate Functions In LINQ ************************
            // Count(), Average(), MAX(), SUM()
            // **************************Find the total number of Employees
            var numOfEmp = (from e in employees
                            select n).Count();
            Console.WriteLine("Number of total Employees are : " + numOfEmp);

            // *****************************find the number of employees who draw salary more than 90,000
            var countSal = (from e in employees
                            where e.Salary>90000
                            select n).Count();
            Console.WriteLine("Number of Employees who draw salary more than 90000 : " +countSal);


            // **************************Add salary of all employees
            var sumSalaries = (from e in employees
                               select e.Salary).Sum();
            Console.WriteLine("Sum of salaries of all employees : " + sumSalaries);

            //****************************Find the Citiwise average Salary *****************
            // just grouping by on the basis of city
            var citywise = (from e in employees
                            group e by e.City into grp
                            select grp);
            foreach (var grp in citywise)
            {
                Console.WriteLine(grp.Key);
                foreach (var e in grp)
                {
                    Console.WriteLine($"{e.Name}  with salary {e.Salary}");
                }

            }

            // now averagge salary as well 
            var avgSal = (from e in employees
                          group e by e.City into grp
                          select (grp.Key,grp.Average(x =>x.Salary)));
            foreach (var item in avgSal)
            {
                Console.WriteLine($"{item.Key}  {item.Item2}");
            }
        }
    }
}
