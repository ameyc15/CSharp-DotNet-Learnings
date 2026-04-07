namespace Day02_ReleaseVsDebugMode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Debug vs Release Mode Experiment ===== \n");
            Console.WriteLine("=== This program will be run by Release Mode and Debug Mode ===\n");
            Console.WriteLine("=== Open the project in file explorer and compare the size of dlls made by both modes ===\n");
            Console.WriteLine("=== dll made by Debug mode should be larger in size than dll made by Release Mode === \n");

            // 1 . We are going to do Matrix Multiplication which is CPU Intensive for the local machine
            Console.WriteLine("1. Running Matrix Multiplication...");
            int[,] result = MultiplyMatrices();
            Console.WriteLine($"Matrix result [0,0] = {result[0, 0]}");
            Console.WriteLine($"Matrix result [1,1] = {result[1, 1]}");
            Console.WriteLine($"Matrix result [2,2] = {result[2, 2]}");
            Console.WriteLine($"Matrix result [3,3] = {result[3, 3]}");


            //2 . We will be count the prime numbers 
            Console.WriteLine("2. Finding the Prime Numbers from 0 to 100000");
            int primeCount = CountPrimes(100000);
            Console.WriteLine($"Total Prime Numbers from 0 to 100000 are : {primeCount}");

            //3 . Fibonacci
            Console.WriteLine("Counting the Fibonacci upto 50th term");
            long fibResult = Fibonacci(50);
            Console.WriteLine($"50th Fibonacci Number : {fibResult}");

            //4. Bubble Sort
            Console.WriteLine("Sorting by Bubble Sort ...");
            int[] bubbleSort = BubbleSort();
            Console.WriteLine($"First Number : {bubbleSort[0]}  Last Number : {bubbleSort[9999]}");

            //5. StringOperation
            Console.WriteLine("Memory Heavy String Operation Started ....");
            int stringCount = StringOperation();
            Console.WriteLine($"Count of the words is : {stringCount}");


        }

        // 1. Method to implement the Matrix Multiplication
        static int[,] MultiplyMatrices()
        {
            int size = 10;
            int[,] MatrixA = new int[size, size];
            int[,] MatrixB = new int[size, size];
            int[,] MatrixC = new int[size, size];

            //We will populate the matrices 
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    MatrixA[i, j] = i + j;
                    MatrixB[i, j] = i * j;
                }
            }
            Console.WriteLine(MatrixA);
            Console.WriteLine(MatrixB);

            //Mutliplication of Matrices
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        MatrixC[i, j] += MatrixA[i, k] * MatrixB[k, j];
                    }
                }
            }
            return MatrixC;
        }

        //2. Method to Count the Prime Numbers upto 100000
        static int CountPrimes(int limit)
        {
            int count = 0;

            for (int num = 2; num <= limit; num++)
            {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) count++;
            }
            return count;
        }
        // 3. Method to Implement Fibonacci 
        static long Fibonacci(int n)
        {
            if (n <= 1) return n;
            long a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                long temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

        // 4. Method for Bubble sorting
        static int[] BubbleSort()
        {
            int[] numbers = new int[100000];
            Random rand = new Random(42);

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = rand.Next(1, 100000);
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - j - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[i] = numbers[j + 1];
                        numbers[i] = temp;
                    }
                }
            }
            return numbers;
        }
        // summary :  Below method actually has no meaning we are just increasing the computational load on system so that 
        // we can actually see the meaningful difference in the size of dll made by Release Mode and Debug Mode 
        // 5. Memory Heavy String Operation 
        static int StringOperation()
        {
            string[] words = { "C#", "DotNet", "EntityFramework", "SQL", "DebugMode", "ReleaseMode", "SSMS" };
            int count = 0;
            for (int i = 0; i <= 10000; i++)
            {
                string word = words[i % words.Length].ToUpper().ToLower().Trim();
                count++;
            }
            return count;


        }
    }
}