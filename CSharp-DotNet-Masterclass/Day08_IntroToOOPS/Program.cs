namespace Day07_IntroToOOPS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello  World");

            // create a class named person with name and age as fields and method greet

            Person p1 = new Person();

            p1.Greet();
            Console.WriteLine(p1.age);
            Console.WriteLine(p1.name);
        }
    }
}