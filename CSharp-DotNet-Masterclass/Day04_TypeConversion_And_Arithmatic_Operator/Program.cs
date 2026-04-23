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

            // there's another method for Explicit Type casting using Inbuilt Functions
            double secondVar = 7.98;
            Console.WriteLine(Convert.ToInt32(secondVar)); // but this will do roundoff to nearest integer which is 8

            double thirdVar = 10.49;
            Console.WriteLine(Convert.ToInt32(thirdVar)); // this will print 10

            //ARITHMATIC OPERATOR
            // Uninary Operator and Binary Operator
            // Binary Operator
            // sum, substract, multiply, division, mod, increment, decrement 
            int sum, sub, mul, div, mod ;
            sum = sub = mul = div = 0;
            int firstNumber = 100;
            int secondNumber = 5;

            sum = firstNumber + secondNumber;
            sub = firstNumber - secondNumber;
            mul = firstNumber * secondNumber;
            div = firstNumber / secondNumber;
            mod = firstNumber % secondNumber;

            Console.WriteLine(sum); // 105
            Console.WriteLine(sub); // 95
            Console.WriteLine(mul); // 500
            Console.WriteLine(div); // 20
            Console.WriteLine(mod); // 0
            Console.WriteLine(firstNumber++); // first value is send to Write method then its incremented but method got the old value so it prints old value
            Console.WriteLine(++secondNumber); // frist increment then assignment 6

            //practice question of pre post increment decrement
            Console.WriteLine("=====================Pre Post Increment and Decrement");
            int a = 100;
            int b = 50;
            a++;
            --a;
            --b;
            ++b;
            Console.WriteLine(a);  // 100
            Console.WriteLine(b); // 50

            // *****some famous interview questions are pedning here will update here****
            // Swapping using third var and 2 ways without thirad var 
        }
        
    }
}
