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
                for (int j=0; j<size; j++)
                {
                    MatrixA[i, j] = i + j;
                    MatrixB[i, j] = i * j;
                }
            }
            Console.WriteLine(MatrixA);
            Console.WriteLine(MatrixB);

            //Mutliplication of Matrices
            for (int i=0; i<size; i++)
            {
                for(int j=0; j<size;j++)
                {
                    for(int k=0; k<size; k++)
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

            for(int num =2; num<=limit; num++)
            {
                bool isPrime = true;

                for(int i=2; i<= Math.Sqrt(num); i++)
                {
                    if(num % i == 0)
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
            for(int i=2; i<=n; i++)
            {
                long temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }



    }
}