using Bank;

namespace Day10_IntroToConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // namespace is  collection of classes or interfaces clubed together
            // 
            BankAccount account;    // only reference variable created as account no memeory allocated 
            BankAccount account1 = new BankAccount();   // cotr with no parameter invoked
            BankAccount account2 = new BankAccount(2000);   // cotr with 1 parameter invoked
            BankAccount account3 = new BankAccount("HDFC", 3000); // cotr with 2 parameter invoked
        }
    }
}
