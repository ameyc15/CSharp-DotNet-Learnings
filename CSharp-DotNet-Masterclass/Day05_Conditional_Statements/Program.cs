namespace Day05_Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("***********Program has Stared***********");
                Console.WriteLine("Program to Calculate the circle of Radius");
                AreaOfCircle();
                Console.WriteLine("\n...................................................");

                Console.WriteLine("Program to Categorise Height");
                CategoryOfHeight();
                Console.WriteLine("\n...................................................");

                Console.WriteLine("Prgram to calculate Largest Number using if else statements ");
                LargestNumber();
                Console.WriteLine("\n......................................................");

                Console.WriteLine("Prgram to Calculate Largest Number Refactored Above Method");
                LargestNum();
                Console.WriteLine("\n...................................................");

                Console.WriteLine("Prgram to Calculate Largest Number using Max function");
                MaxNumnber();
                Console.WriteLine("\n.....................................................");

                ///<summary>
                /// Problem 1: Calculates the area of a circle based on user-provided radius.
                ///</summary>
                static void AreaOfCircle()
                {
                    double pi = Math.PI;
                    Console.WriteLine("Please enter the radius of circle : ");

                    // string input = Console.ReadLine();

                    double radiusOfCircle;

                    while (!double.TryParse(Console.ReadLine(), out radiusOfCircle))
                    {
                        Console.WriteLine("Invalid Value for Radius. Please Enter Valid Numeric Value");

                    }

                    double areaOfCircle = pi * radiusOfCircle * radiusOfCircle;

                    Console.WriteLine($"Area of Circle is : {areaOfCircle:F2}");
                }

                //<summary>
                /// Problem 2: Categorizes a person's height after converting inches to centimeters.
                //</summary>
                static void CategoryOfHeight()
                {
                    Console.WriteLine("Please enter height of Person in Inches");
                    float heightInInches;
                    while (!float.TryParse(Console.ReadLine(), out heightInInches))
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
                    else if (heightInCm < 195)
                    {
                        Console.WriteLine("Person is tall");
                    }
                    else
                    {
                        Console.WriteLine("Person is of abnormal Height");
                    }
                }

                /// <summary>
                /// Write a C# program to find out largest number among three numbers, using "if".
                /// </summary>
                void LargestNumber()
                {
                    int firstNumber, secondNumber, thirdNumber;


                    while (!int.TryParse(Console.ReadLine(), out firstNumber))
                    {
                        Console.WriteLine("Invalid Integer...Please Enter Valid Integer Number");
                    }
                    Console.WriteLine("Your Fisrt Number is " + firstNumber);
                    while (!int.TryParse(Console.ReadLine(), out secondNumber))
                    {
                        Console.WriteLine("Innvalid Integer.. Please Enter Second Valid Whole Number");
                    }
                    Console.WriteLine("Your Second Number is" + secondNumber);
                    while (!int.TryParse(Console.ReadLine(), out thirdNumber))
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
                        if (secondNumber > thirdNumber)
                        {
                            Console.WriteLine($"Largest Number is : {secondNumber}");
                        }
                        else
                        {
                            Console.WriteLine($"Largest Number is : {thirdNumber}");
                        }
                    }
                }

                /// <summary>
                /// Write a C# program to find out largest number among three numbers, using "if"
                /// </summary>
                void LargestNum()
                {
                    // This is more advanced solution compared to above one
                    int firstNum, secondNum, thirdNum, largest;
                    Console.WriteLine("Enter theree Numbers ");
                    while (!int.TryParse(Console.ReadLine(), out firstNum))
                    {
                        Console.WriteLine("Invalid Input...Enter Whole Number");
                    }
                    while (!int.TryParse(Console.ReadLine(), out secondNum))
                    {
                        Console.WriteLine("Invalid Input...Enter Whole Number");
                    }
                    while (!int.TryParse(Console.ReadLine(), out thirdNum))
                    {
                        Console.WriteLine("Invalid Input...Enter Whole Number");
                    }
                    Console.WriteLine("First Number is " + firstNum);
                    Console.WriteLine("Second Number is " + secondNum);
                    Console.WriteLine("Third Number is " + thirdNum);
                    if (firstNum >= secondNum && firstNum >= thirdNum)
                    {
                        largest = firstNum;
                    }
                    else if (secondNum >= firstNum && secondNum >= thirdNum)
                    {
                        largest = secondNum;
                    }
                    else
                    {
                        largest = thirdNum;
                    }
                    Console.WriteLine("Largest Nummber is :" + largest);
                }

                /// <summary>
                /// Finding the max number using in-built functions
                /// </summary>
                void MaxNumnber()
                {
                    int[] numbers = new int[3];
                    Console.WriteLine("Enter Three Numbers");
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine($"Enter your {i + 1}st Number");
                        while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                        {
                            Console.WriteLine("Invalid Input... Please Enter Whole Number");
                        }
                    }
                    Console.WriteLine($"Your Numbers are : {string.Join(", ", numbers)}");
                    int largestN = numbers.Max();
                    Console.WriteLine("Largest Number is :" + largestN);

                    //test
                    //test2
                }
            }
        }
    }
}