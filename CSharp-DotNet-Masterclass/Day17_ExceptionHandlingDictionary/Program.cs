namespace Day17_ExceptionHandlingDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0;

            try
            {
                if(b == 0)
                {
                    throw new ArithmeticException("Division by Zero is not allowed");
                }
                Divide(a, b);                
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine( ex.ToString());
                Console.WriteLine("Arithmatic Catch Block executed");
            }
            catch (Exception ex) 
            { 
                Console.WriteLine("Exception occured while executing the program " +ex.ToString());
            }
            finally
            {
                Console.WriteLine("Final Block Executes");
            }

            static void Divide(int a, int b) 
            {
                int div = a / b;
                Console.WriteLine(div);
            }
        }
    }
}
