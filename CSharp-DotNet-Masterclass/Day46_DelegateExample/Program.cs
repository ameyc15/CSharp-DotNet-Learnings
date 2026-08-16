namespace Day46_DelegateExample
{
    public delegate void Notify();
    internal class Program
    {
        public delegate int Operation(int a, int b);
        static int Add (int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        


        // example 2


        public static void Method1()
        {
            Console.WriteLine("Method 1 Called");
        }

        public static void Method2() 
        {
            Console.WriteLine("Method 2 called");
        }
        static void Main(string[] args)
        {
            Operation opsAdd = Add;
            Console.WriteLine(opsAdd(10,15));
            Operation opsSub = Sub;
            Console.WriteLine(opsSub(100,20));

            //___________________________________________________
            // example : 2

            Notify notify = Method1;
            notify += Method2;
            notify();

            // single cast = pointing to single method
            // multi cast = pointing to multiple method

            // built in Delegates 
            // Action : delegate which returns void and take up to 16 params
            // Fun : returns value and take upto 16 params
            // predicate : returns true or false




        }
    }
}
