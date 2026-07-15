namespace Day15_OOPSPartOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Abstraction => hiding complexity
            // Encapsulation => Binidng  data and memebers together in single unit like class 
            // Inheritance => Reusebility 
            // Polymorphism => Ability to show more than one form
            Employee employee = new Employee()
            {
                FirstName = "Amey",
                LastName = "Chaudhary",
                CompanyName = "QueenStreet",
                EmployeeId = 100065
            };
            string fullname = employee.GetName();
            Console.WriteLine(fullname);

        }
    }
}