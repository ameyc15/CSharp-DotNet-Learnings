namespace Day06_DoWhileAndForLoops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int i = 1;
            while (i < 10)
            {
                Console.WriteLine("infinite loop");
                i++;
            }

            int a = 10;
            for(;a<100 ;a++ )
            {
                Console.WriteLine("for loop");
            }
            int b = 5;
            do
            {
                Console.WriteLine(b + " ");
                b--;
            } while (b > 5);
            
            for(int c= 0; c<3; c++)
            {
                if (c == 1)
                    continue;    // continue skips the rest of the code in that iteration and moves to next iteration
                Console.WriteLine(c);
            }

            for(int d = 1; d < 10; d++)
            {
                if (d == 5)
                    break;
                Console.WriteLine(d);
            }
        }
    }
}