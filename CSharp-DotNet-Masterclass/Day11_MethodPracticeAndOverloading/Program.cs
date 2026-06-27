using System.Security.Cryptography.X509Certificates;

namespace Day11_MethodPracticeAndOverloading
{
    internal class Program
    {
        public static void CityMethod(double population ,string city = "Pune")
        {
            Console.WriteLine(city);
            Console.WriteLine(population);
        }
        public static int Sum(int x, int y) // method overloading
        {
            return x + y;
        }
        public static int Sum(int x, int y, int z) // method overloading
        {
            return x + y + z;
        }
        public static string employeeName = "Amey";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CityMethod(100000);
            CityMethod(200000,"Mumbai"); 

            int output=Sum(100, 200);
            Console.WriteLine(output);

            int sum1 = Sum(1,2);
            Console.WriteLine(sum1);

            int sum2 = Sum(1,2,3);
            Console.WriteLine(sum2);

            string cityName = "Ahilyanagr";
            Console.WriteLine(cityName);
            Console.WriteLine(employeeName);

            // Write a class which will contain employee name and salary
            // create 3 objects of class 
            // 1. Peter 200
            // 2. Rob 50
            // 3. Donna 100
            // print the name of the employee with highest salary

            Employee employee1, employee2, employee3;
            employee1 = new Employee();
            employee1.name = "Peter";
            employee1.salary = 200;

            employee2 = new Employee();
            employee2.name = "Rob";
            employee2.salary = 500;

            employee3 = new Employee();
            employee3.name = "Donna";
            employee3.salary = 1000;

            // find the maximum salary 
            if(employee1.salary > employee2.salary) 
            {
                if(employee1.salary > employee3.salary)
                {
                    Console.WriteLine("Peter has the highest salary");
                }
                else
                {
                    Console.WriteLine("Donna has the highest salary");
                }
            }
            else
            {
                if (employee3.salary > employee2.salary)
                {
                    Console.WriteLine("Donna has the highest salary");
                }
                else
                {
                    Console.WriteLine("Rob has the highest salary");
                }
            }
            string companyName = "newgen";
            Console.WriteLine(companyName.ToUpper());

            // string comparison using in built method ComparedTo
            string stringOne = "AMEY";
            string stringTwo = "amey";

            Console.WriteLine(stringOne.CompareTo(stringTwo));

            int x = stringOne.ToLower().CompareTo(stringTwo);
            if(x == 0)
            {
                Console.WriteLine("Both Strings are equal");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }
            // Repalce method for string
            string test = "Replace";
            Console.WriteLine(stringOne.Replace("EY",test)); // AMReplace this should be the output

            // name.Length
            // stringOne == stringTwo;
            // stringOne.Equals(stringTwo);
            // stringOne.ComparedTo(stringTwo);
        }
    }
}
