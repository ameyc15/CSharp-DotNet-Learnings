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
            Console.Write(counter);

            // QUESTION 3 : Find The Sum of All Numbers in Array
        }
    }
}