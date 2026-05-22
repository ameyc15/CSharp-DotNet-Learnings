using System.Linq.Expressions;

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
                    break;      // break will exit teh loop altogether will not further iterate
                Console.WriteLine(d);
            }

            string monthName = default;
            Console.WriteLine("Enter any month number");
            int result;
            int monthNumber = Convert.ToInt32(Console.ReadLine());    
            

            switch (monthNumber)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "Octomber";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    Console.WriteLine("Invalid Input... Please Enter integer between 1 to 12");
                    break;              

            }
            Console.WriteLine(monthName);
            
        }
    }
}