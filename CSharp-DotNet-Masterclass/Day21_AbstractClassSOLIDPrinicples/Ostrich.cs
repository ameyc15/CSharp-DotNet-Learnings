using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_AbstractClassSOLIDPrinicples
{
    internal class Ostrich : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("An Ostrich Can not fly");
        }
    }
}
