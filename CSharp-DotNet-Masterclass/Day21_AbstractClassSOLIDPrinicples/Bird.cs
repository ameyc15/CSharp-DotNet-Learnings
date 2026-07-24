using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_AbstractClassSOLIDPrinicples
{
    internal class Bird : IFlyable
    {
        public virtual void Fly()
        {
            Console.WriteLine("A Bird Can Fly");
        }
    }
}
