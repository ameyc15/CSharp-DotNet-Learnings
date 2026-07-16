using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_EmpMgmtSysDemo
{
    public class Dog : Animal
    {

        public Dog(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} Says : Woof Woof" );
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} moves on 4 legs");
        }
     
    }
}
