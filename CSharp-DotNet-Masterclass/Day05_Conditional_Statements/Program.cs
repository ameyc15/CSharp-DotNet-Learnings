namespace Day05_Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // write a program to calculate the area of circle based on given value of radius
            double pi = Math.PI;
            Console.WriteLine("Please enter the radius of circle : ");

            // string input = Console.ReadLine();

            double radiusOfCircle;

            while (!double.TryParse(Console.ReadLine(),out radiusOfCircle))
            {
                Console.WriteLine("Invalid Value for Radius. Please Enter Valid Numeric Value");

            }

            double areaOfCircle = pi * radiusOfCircle * radiusOfCircle;

            Console.WriteLine($"Area of Circle is : {areaOfCircle:F2}");
        }
    }
}