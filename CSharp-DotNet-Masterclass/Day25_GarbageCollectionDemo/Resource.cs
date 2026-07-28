using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day25_GarbageCollectionDemo
{
    internal class Resource : IDisposable
    {
        // diff method for db connection or heavy api call

        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum is " + (a+b));
        }
        public void Dispose()
        {
            Console.WriteLine("Resources are cleaned up ...");
        }
    }
}
