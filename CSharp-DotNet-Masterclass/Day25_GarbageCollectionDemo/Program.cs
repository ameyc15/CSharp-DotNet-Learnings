using System.Text;

namespace Day25_GarbageCollectionDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Garbage Collection : Programmers don't need to know how to allocate and release memory or manage memory object 
            //GC.Collect() method is called manually to invoke garbage collection.
            //it is used to clean up the memory space efficiently 
            //.Net automatically runs the garbage collection periodically.


            Sample sample =  new Sample();

            // Generations
            // Gen : 0 -> All objects are first collected, out of scope objects doen't live here 
            // Gen : 1 -> Object that survive into gen 0, moved to gen 1
            // Gen : 2 -> 

            Console.WriteLine(GC.GetGeneration(sample));
            GC.Collect();
            Console.WriteLine(GC.GetGeneration(sample));

            using (Resource r = new Resource())
            {
                r.Sum(10, 20);
            }//Dispose method will get called automatically after the scope is finished

        }
    }
}
