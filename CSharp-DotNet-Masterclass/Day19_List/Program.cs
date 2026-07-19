namespace Day19_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Pune");
            cities.Add("Mumbai");

            Console.WriteLine(cities[0]);
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            cities.Insert(1, "London");

            foreach (var c in cities)
            {
                Console.WriteLine(c);
            }
            bool isPresent = cities.Contains("Pune"); // case sensitive you can use ToLower() and ToUpper()
            if (isPresent == true)
            {
                Console.WriteLine("Pune is present in the list");
            }
            else
            {
                Console.WriteLine("Pune is not in list");
            }
            //*** Interview Questions ***
            // Find the valid list of emails from the given list of emails 
            // a@.comgmail, @gmailcom.a, agmail.com, gmail.rohit.@, rahul@gmail.com, test@example.com, invalid@, user+domain@.co
            // @ should present
            // string should end with ".com" sbustring
            List<string> listEmails = new List<string>()
            {
                "@gmailcom.a" ,
                "agmail.com",
                "gmail.rohit.@",
                "rahul@gmail.com",
                "test@example.com",
                "invalid@",
                "user+domain@.co"
            };
            List<string> validEmails = new List<string>();
            foreach (var e in listEmails)
            {
                if (e.Contains("@") && e.EndsWith(".com"))
                {
                    validEmails.Add(e);
                }
            }
            foreach (var e in validEmails)
            {
                Console.WriteLine(e);
            }

            // Interview Questions
            // Commbine the two list excluding common element
            List<string> first = new List<string>()
            {
                "Pune",
                "Bombay",
                "Madras",
                "Delhi"
            };
            List<string> second = new List<string>()
            {
                "Bengluru",
                "Pune"
            };
            // Logic : 
            // First Add the first list as it 
            // Iterate over the combinedlist to check if the element in second list already present
            // if present don't add if absent add
            List<string> combinedList = new List<string>();
            foreach (var item in first)
            {
                combinedList.Add(item);
            }

            foreach (var c in second)
            {
                if (!combinedList.Contains(c))
                {
                    combinedList.Add(c);
                }
            }
            Console.WriteLine("_________________CombinedList_____________________");

            foreach(var c in combinedList)
            {
                Console.WriteLine(c);
            }
            // using LINQ
            first.Union(second).ToList();
            // 
            first.Concat(second).Distinct().ToList();

            // Interview Question 3
            // Create a list of employee with Id, Salary, Name
            // 1.  Find the Lowest Salary
            // 2. Find the Highest salary
            // 3. Find the with second Highest salary
            //Logic : First create employee class having threee fields W

            List<Employee> employees = new List<Employee>()
            {
                new Employee{Id=1,Salary=10000,Name = "Vinit"},
                new Employee{Id=2, Salary = 15000, Name = "Akash"},
                new Employee{Id=3, Salary=20000, Name = "Shreya"},
                new Employee{Id=4, Salary = 30000, Name = "Shruti"},
                new Employee{Id=5, Salary = 30000, Name = "Amey"}

            };
            foreach(var emp in employees)
            {
                Console.WriteLine(emp.Id +" "+ emp.Name+" "+ emp.Salary);
            }

            


        }
    }
}
