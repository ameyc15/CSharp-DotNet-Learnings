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

            Console.WriteLine("======= Size of all the Value Types =======");

            Console.WriteLine("======== Size of char/bool ========");
            Console.WriteLine($"Size of bool : {sizeof(bool)} byte");
            Console.WriteLine($"Size of char : {sizeof(char)} byte");

            //Integers
            Console.WriteLine("======== Size of Integer =======");
            Console.WriteLine($"Size of Byte : {sizeof(byte)} byte"); 
            Console.WriteLine($"Size of Short : {sizeof(short)} bytes");
            Console.WriteLine($"Size of Int : {sizeof(int)} bytes");
            Console.WriteLine($"Size of Long : {sizeof(long)} bytes");

            //floating point 
            Console.WriteLine("======= Size of Floating Type Variables =======");
            Console.WriteLine($"Size of float : {sizeof(float)} bytes");
            Console.WriteLine($"Size of double : {sizeof(double)} bytes");
            Console.WriteLine($"Size of Decimal :{sizeof(decimal)} bytes");

            
        }
    }
}