namespace Day21_AbstractClassSOLIDPrinicples
{
    public class Program
    {
        static void Main(string[] args)
        {
            // SOLID Prinicples
            // S - Single Responsibility - Each class should have single responsibility
            // O = Open Closed - Open for Extension CLosed for Modification using abstraction
            // L - Liskov Substitution
            // I - Interface Prinnicple
            // D - Dependency Inversion
            Circle circle = new Circle();
            Console.WriteLine(circle.CalculateArea());

            Rectangle rectangle = new Rectangle();  
            Console.WriteLine(rectangle.CalculateArea());

            //Liskov Substitution : Derived Classes should be able to substitue the Base class 
        }
    }
}
