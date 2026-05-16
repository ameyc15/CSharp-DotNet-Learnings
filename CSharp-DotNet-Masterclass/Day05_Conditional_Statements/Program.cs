namespace Day05_Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // write a program to calculate the area of circle based on given value of radius
            double pi = Math.PI;
            Console.WriteLine("Please enter the radius of circle : ");

            // string input = Console.ReadLine();

            double radiusOfCircle;

            while (!double.TryParse(Console.ReadLine(),out radiusOfCircle))
            {
                Console.WriteLine("Invalid Value for Radius. Please Enter Valid Numeric Value");

            }

            double areaOfCircle = pi * radiusOfCircle * radiusOfCircle;

            Console.WriteLine($"Area of Circle is : {areaOfCircle:F2}");

            // Write a program to find out "category of height" based on the given height of a person (in inches), using "if".
            Console.WriteLine("Please enter height of Person in Inches");
            float heightInInches;
            while(!float.TryParse(Console.ReadLine(), out heightInInches))
            {
                Console.WriteLine("Invalid Input. Please Enter Height of Person in Inches");

            }
            double heightInCm = 2.54 * heightInInches;
            if (heightInCm < 150)
            {
                Console.WriteLine("Person is Dwarf");
            }
            else if (heightInCm < 165)
            {
                Console.WriteLine("Person is of Average Height");
            }
            else if(heightInCm < 195)
            {
                Console.WriteLine("Person is tall");
            }
            else
            {
                Console.WriteLine("Person is of abnormal Height");
            }

            // Write a C# program to find out largest number among three numbers, using "if".

            int firstNumber, secondNumber, thirdNumber;
           
            
            while(!int.TryParse(Console.ReadLine(),out firstNumber))
            {
                Console.WriteLine("Invalid Integer...Please Enter Valid Integer Number");
            }
            Console.WriteLine("Your Fisrt Number is " + firstNumber);
            while (!int.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Innvalid Integer.. Please Enter Second Valid Whole Number");
            }
            Console.WriteLine("Your Second Number is" + secondNumber);
            while(!int.TryParse(Console.ReadLine(), out thirdNumber))
            {
                Console.WriteLine("Invalid Input... Please Enter the Third Valid Whole Number");
            }
            Console.WriteLine("Your Third Number is " + thirdNumber);

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine($"Largest Number is : {firstNumber}");
                }
                else
                {
                    Console.WriteLine($"Largest Number is : {thirdNumber}");
                }
            }
            else
            {
                if(secondNumber > thirdNumber)
                {
                    Console.WriteLine($"Largest Number is : {secondNumber}");
                }
                else
                {
                    Console.WriteLine($"Largest Number is : {thirdNumber}");
                }
            }


        }
    }
}