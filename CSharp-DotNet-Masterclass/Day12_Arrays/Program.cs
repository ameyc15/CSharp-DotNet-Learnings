namespace Day12_Arrays_Static_PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[0]);

            // Find the maximum number in the array

            int maxNumber = int.MinValue;
            Console.WriteLine(maxNumber);
            for (int i = 0; i < numbers.Length; i++)
            {
                if(maxNumber<=numbers[i])
                    maxNumber = numbers[i];
            }
            Console.WriteLine(maxNumber);
        }
    }
}