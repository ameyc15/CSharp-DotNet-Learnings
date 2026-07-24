using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_AbstractClassSOLIDPrinicples
{
    public abstract class Shape
    {
        // can not create an object using new keyword
        // can contain abstract members (methods with no body) or concrete members 
        // any non abstract class inheriting from it must implement all abstract methods 
        // unlike interface it can contains fields and constructor
        // to give common implementation across child class we use abstract classes 

        public abstract double CalculateArea();

        public double GetArea()
        {
            return 5;
        }
    }
}
