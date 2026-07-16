
namespace Day16_EmpMgmtSysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance 

            CreditCard creditCard = new CreditCard(); // Defualt Constructor of parent class first then current class

            CreditCard creditCard1 = new CreditCard(100); // invoked parameterised cont of base class using base keyword

            // Polymorphism
            // Compile Time Polymorphism ==> Overloading
            Payment payment = new Payment(); //
            payment.ProcessPayment(100); // method with only one param is invoked 
            payment.ProcessPayment(999, "SBI");

            // Run Time Polymorphism ==> Overriding
            Animal[] animals = new Animal[]
            {
                new Dog("Bruno"),
                new Bird("Tweeti")
            };
            foreach(Animal animal in animals) 
            {
                animal.MakeSound();
                animal.Move();
                Console.WriteLine();
            }

        }
    }
}
