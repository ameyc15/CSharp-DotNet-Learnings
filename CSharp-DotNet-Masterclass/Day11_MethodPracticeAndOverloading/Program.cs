namespace Day11_MethodPracticeAndOverloading
{
    internal class Program
    {
        public static void CityMethod(double population ,string city = "Pune")
        {
            Console.WriteLine(city);
            Console.WriteLine(population);
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Method(int x)
        {
            return x;
            Console.WriteLine();
        }
         
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CityMethod(100000);
            CityMethod(200000,"Mumbai"); 

            int output=Sum(100, 200);
            Console.WriteLine(output);
        }
    }
}
