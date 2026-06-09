using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Day08_IntroToOOPS")]

namespace Day09_ClassObjectFieldMethod
{
    internal class Employee
    {
        public string employeeName;
        public int employeeAge;

        public int empSalary;
        public int empId;
        public static int departmentId; // memory allocated at class level not at object level because static

        public int  GetSalary()
        {
            return empSalary;
        }

        public static int GetDepartmentId() // memory in class level 
        {
            return departmentId;
        }

        // Question1 : Create an employee class with filed Id, name, salary
        // Write a method to display all the fields 
        public void Display()
        {
            Console.WriteLine($"Id {empId} Name {employeeName} Salary {empSalary}");
        }
    }
}
