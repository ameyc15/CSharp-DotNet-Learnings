using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_EmpMgmtSysDemo
{
    public  class Animal
    {
        public string Name;

        public Animal(string name)
        {
            Name = name;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes sound ");
        }
        public virtual void Move()
        {
            Console.WriteLine($"{Name} moves ");
        }
    }
}
