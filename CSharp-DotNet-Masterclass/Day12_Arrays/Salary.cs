using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Arrays_Static_PartialClass
{
    internal class Salary
    {
        public string Name { get; set; }
        public static int SalaryAmount {  get; set; }

        public static void Show()
        {
            // Console.WriteLine(Name);
            // Static Method Can not access not access instance fields 
            // Because instance fields belongs to the objects 
            // and static method has no objects context 

            Console.WriteLine(SalaryAmount); // can access static fields 
        }
    }
}
