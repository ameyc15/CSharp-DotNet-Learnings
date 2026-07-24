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
            // I - Interface Segregation
            // D - Dependency Inversion
            Circle circle = new Circle();
            Console.WriteLine(circle.CalculateArea());

            Rectangle rectangle = new Rectangle();  
            Console.WriteLine(rectangle.CalculateArea());

            //Liskov Substitution : Derived Classes should be able to substitue the Base class 
            // Bird class 
            Bird b = new Bird();

            // but 
            // Bird b = new Ostrich(); invalid because it chaning the behaviour of the base class
            // we can solve that using IFlyable interface 
            IFlyable flyable;
            flyable = new Bird();
            flyable.Fly();

            flyable = new Ostrich();
            flyable.Fly();

            // Interface Segregation
            // Dependecny Inversion:
            // High Level Module Can not be dependent on Low level Module

        }
    }
}
