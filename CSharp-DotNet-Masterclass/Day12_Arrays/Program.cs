using System.IO;
using System.Runtime.Intrinsics.X86;

namespace Day12_Arrays_Static_PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[0]);

            // QUESTION: 1 Find the maximum number in the array

            int maxNumber = int.MinValue;
            Console.WriteLine(maxNumber);
            for (int i = 0; i < numbers.Length; i++)
            {
                if(maxNumber<=numbers[i])
                    maxNumber = numbers[i];
            }
            Console.WriteLine(maxNumber);


            // alternative1:method rather taking absolute MinValue beacuse it doesn't consider the array contains only positive values
            int[] numbersArr = new int[10] {23,67,12,34,65,78,1000,9,12,1};
            int maxNum = numbersArr[0];
            for (int i=1; i<numbersArr.Length; i++)
            {
                if (numbersArr[i] > maxNum)
                {
                    maxNum = numbersArr[i];
                }
            }
            Console.WriteLine(maxNum);

            // alternative2:Production Ready using LINQ
            int[] numbersArr1 = new int[10] { 52, 47, 7, 21, 69, 23, 33, 10, 999, 4798 };
            int maxNum1 = numbersArr1.Max();
            Console.WriteLine(maxNum1);

            // QUESTION 2 : Count the Even Numbers in Array
            int counter = 0;
            for(int i=0; i<numbersArr1.Length; i++)
            {
                if (numbersArr1[i] % 2 ==0)
                    counter++;
            }
            Console.WriteLine(counter);

            // QUESTION 3 : Find The Sum of All Numbers in Array
            int sum = 0;
            for (int i=0;i<numbersArr1.Length; i++)
            {
                sum = sum+ numbersArr1[i];
            }
            Console.WriteLine(sum);

            // Question 4 : Find the missing number in array
            // Logic used : sum of n natural numbers = n*(n+1)/2 

            int[] givenArray = new int[5] {2,1,0,4,3};
            int n = givenArray.Length;
            int sumOfSerial = n * (n + 1) / 2;
            int actualSum = 0;
            for(int i=0; i<n; i++)
            {
                actualSum += givenArray[i];
            }
            Console.WriteLine(Math.Abs(actualSum-sumOfSerial));

            // Question 5 : Find the Duplicate number in array
            int[] dupArray = new int[8] { 5, 3, 8, 3, 1, 5, 9, 8 };
            Console.WriteLine("Duplicate found : ");
            for(int i=0; i< dupArray.Length; i++)
            {
                for(int j=i+1;  j<dupArray.Length; j++)
                {
                    if(dupArray[j] == dupArray[i])
                    {
                        Console.WriteLine(dupArray[i]);
                    }
                }
            }



            // Question 6 : Find the non Duplicate number in array


            // Partial Class and Partial method
            //1.All parts must use the keyword → partial
            //2.All parts must have same class name
            //3. All parts must be in same namespace
            //4. All parts must be in same project
            //5. At compile time → merged into ONE class automatically

            Employee employee = new Employee();
            employee.name = "Kelvin";
            employee.age = 32;
            employee.displayEmployee();
            employee.displayAge();

            //static keyword
            // used in field. method, class , constructor

            BankAccount acc1 = new BankAccount("Rahul", 50000);
            acc1.DisplayInfo();

            BankAccount acc2 = new BankAccount("Padamsinh", 250000);
            acc2.DisplayInfo();

            BankAccount acc3 = new BankAccount("Amey", 80000);
            acc3.DisplayInfo();           

            // Accessing the static field directly via class name and NOT VIA THE OBJECT
            Console.WriteLine($"Total Account via Class : {BankAccount.TotalAccount}");
        }
    }
}