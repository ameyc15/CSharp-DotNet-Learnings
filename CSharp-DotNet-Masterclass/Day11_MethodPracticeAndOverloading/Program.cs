namespace Day11_MethodPracticeAndOverloading
{
    internal class Program
    {
        public static void CityMethod(string city = "Pune")
        {
            Console.WriteLine(city);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CityMethod();
            CityMethod("Mumbai");        }
    }
}
