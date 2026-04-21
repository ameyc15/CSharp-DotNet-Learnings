namespace Day04_TypeConversion_And_Arithmatic_Operator
{
   internal class Program
    {
        // summary
        // Main method is execution starting point and contains flow of execution
        //takes input array of strings 
        // returns nothing
        static void Main(string[] args)
        {           
            // Explicit Type Casting
            // double -> int -> char
            double valuePi = 3.143;
            int valuePiInt = (int)valuePi;
            Console.WriteLine("Variable Type Double valuePi : "+valuePi);
            Console.WriteLine("Varibale Type Int valuePiInt : "+valuePiInt);
        }
        
    }
}
