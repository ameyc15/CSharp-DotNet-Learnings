using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_StringBuilderEnumRefType
{
    internal class Employee
    {
        public int salary;
        public string name = string.Empty;

        public Employee()
        {
            Console.WriteLine("Employee class object initialised using constructor");
        }

        public void Display()
        {
            Console.WriteLine($"Employee salary is {salary} and name is {name}");
        }


    }
}
