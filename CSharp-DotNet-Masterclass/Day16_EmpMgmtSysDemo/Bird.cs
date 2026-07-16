using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_EmpMgmtSysDemo
{
    public class Bird : Animal
    {
        public Bird(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says : tweet tweet");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} flies with wings");
        }
    }
}
