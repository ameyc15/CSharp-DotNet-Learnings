namespace Day09_ClassObjectFieldMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Employee employee1; // only declaration of object no memory allocated
            Employee employee2 = new Employee(); // memeory allocated
            Employee employee3 = new Employee(); // memory allocated

            // Question1 : Create an employee class with filed Id, name, salary
            // Write a method to display all the fields 
            Employee emp1 = new Employee();
            emp1.employeeName = "John";
            emp1.empSalary = 1000;
            emp1.empId = 101;
            emp1.Display();

            Employee emp2 = new Employee();
            emp2.employeeName = "steffani";
            emp2.empSalary = 2000;
            emp2.empId = 102;
            emp2.Display();

            // Question 2 :  Create an BankAcount class with field Balance 
            // write a method  Deposit and GetBalance 
            BankAccount account1 = new BankAccount();
            account1.GetBalance();
            Console.WriteLine($"Balance from account1 : {account1.Deposit(100)}");

            BankAccount account2 = new BankAccount();
            account2.GetBalance(); // 100
            Console.WriteLine($"Balance from account2 : {account2.Deposit(1500)}"); // 1600
            account2.Deposit(account1.Deposit(500)); // 1600 + 700 =2200
            account2.GetBalance();
         
        }
    }
}