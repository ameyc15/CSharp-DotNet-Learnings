using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

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
            Console.WriteLine($"Size of bool : {sizeof(bool)} byte"); // bool is 1 byte even if it only needs 1 bit memory (0 or 1) cpu address memory in Bytes;
            Console.WriteLine($"Size of char : {sizeof(char)} byte"); // Char is 2 Bytes in c# unlike c++ Char is 1 byte beacause C# uses Unicode(UTF16)

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
            Console.WriteLine($"Size of Decimal :{sizeof(decimal)} bytes"); // Highest weight 16 Bytes used in finanacial calclulationns doesn't round off large numbers 


            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine(max);
            Console.WriteLine(min);

            uint uMax = uint.MaxValue;
            uint uMin = uint.MinValue;
            Console.WriteLine(uMax);
            Console.WriteLine(uMin);

            double maxd = double.MaxValue;
            double mind = double.MinValue;
            Console.WriteLine(maxd);
            Console.WriteLine(mind);

            
        }
    }
}