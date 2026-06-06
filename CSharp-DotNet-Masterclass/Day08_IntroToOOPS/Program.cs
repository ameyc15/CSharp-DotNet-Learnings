namespace Day07_IntroToOOPS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello  World");

            // create a class named person with name and age as fields and method greet

            Person p1 = new Person();
            p1.age = 20;
            p1.name = "chaudhary";

            p1.Greet();
            Console.WriteLine($"Age from main method {p1.age}");
            Console.WriteLine($"Name from main method { p1.name}");

            // now create payment class with field amount , isPaymentDone and methods pay

           Payment paymemnt = new Payment();
           paymemnt.Pay();
           Payment.amount1 = 99;

            Console.WriteLine($"Amount from main method {paymemnt.amount}");
            Console.WriteLine($"IsPayment Done from main method {paymemnt.isPaymentDone}");
            Console.WriteLine($"This is static property amount1 : {Payment.amount1}");
            

        }
    }
}