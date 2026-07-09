using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Arrays_Static_PartialClass
{
    internal partial class Employee
    {
        public int age;
        public void displayAge()
        {
            Console.WriteLine("Age of employee is : " + age);
        }

        //  partial method 
        public partial void displayEmployee() 
        {
            Console.WriteLine("Name of employee is  : " + name);
        }

    }

}
