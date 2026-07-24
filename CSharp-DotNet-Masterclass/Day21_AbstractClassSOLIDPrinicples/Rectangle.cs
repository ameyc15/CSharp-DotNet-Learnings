using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_AbstractClassSOLIDPrinicples
{
    internal class Rectangle : Shape
    {
        public double height=10, width=20;
        public override double CalculateArea()
        {
            return height* width;
        }
    }
}
