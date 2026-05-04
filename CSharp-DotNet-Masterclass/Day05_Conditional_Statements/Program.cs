namespace Day05_Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // write a program to calculate the area of circle based on given value of radius

            Console.WriteLine("Enter the radius of circle ");

            string input = Console.ReadLine();
            double radiusOfCricle = Convert.ToDouble(input);

            double areaOfCircle = 3.14 * radiusOfCricle * radiusOfCricle;

            Console.WriteLine($"Area of Circle is : {areaOfCircle}");
        }
    }
}