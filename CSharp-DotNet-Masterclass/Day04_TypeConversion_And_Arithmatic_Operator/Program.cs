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
            //Implicit Type Casting => Converting Smaller Data Type to Larger Data type (Automatic), No Data Loss
            int myVar = 10;
            double myVarDouble = myVar;
            Console.WriteLine(myVar);  // prints 10
            Console.WriteLine(myVarDouble); // also  prints 10


            // Explicit Type Casting => when converting larger data type to smaller might be data loss
            // double -> int -> char
            double valuePi = 3.143;
            int valuePiInt = (int)valuePi;
            Console.WriteLine("Variable Type Double valuePi : "+valuePi); // prints 3.143
            Console.WriteLine("Varibale Type Int valuePiInt : "+valuePiInt); // only pritns 3 => data loss after decimal because memory size
        }
        
    }
}
