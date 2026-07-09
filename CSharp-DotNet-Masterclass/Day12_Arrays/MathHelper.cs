using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Arrays_Static_PartialClass
{
    internal class MathHelper
    {
        // static method can be used directly by the class name
        // No Object Needed 
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if(num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
