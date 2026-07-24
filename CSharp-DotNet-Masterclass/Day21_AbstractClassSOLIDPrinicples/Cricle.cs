using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_AbstractClassSOLIDPrinicples
{
    internal class Circle : Shape
    {
        public double radius=10;
        public override double CalculateArea()
        {
            return 3.14 * radius * radius;
        }
    }
}
