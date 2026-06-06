namespace Day07_IntroToOOPS
{
    public class Person
    {
        public string name = "Amey";
        public int age = 31;
       

        public void Greet()
        {
            Console.WriteLine("Greet method invoked");
            Console.WriteLine("**********************************");
            Console.WriteLine($"Name from Person class Greet method {name}");
            Console.WriteLine($"Age from Person class Greet method {age}");
            Console.WriteLine("**********************************");

        }
    }
}
