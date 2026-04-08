namespace Day03_MainMethod
{
    //the class is internal so it can not be access outside of the dll
    internal class Program
    {   // main method is always static so in order to invoke the method we don't need to
        // create the object. This is entry point of program. In order to run the program first thing 
        // CLR will do is to find a method names Main.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); 
        }
    }
}