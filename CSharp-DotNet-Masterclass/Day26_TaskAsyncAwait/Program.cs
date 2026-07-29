using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Day26_TaskAsyncAwait
{
    internal class Program
    {
        // Notes : 
        // Task : Represents a asynchronous operation that runs in the background and may complete in future
        // A Task is like a promise that some work will finish later.

        // 1. It can run without blocking the current thread
        // 2. It can succeed, fail or can be cancelled.
        // 3. It return result Task<T>

        // Types of Task Returning Value
        // Task         : Asynch work with no return value
        // Task<T>      : Async work that returns a value

        // ValueTask<T> : Optimised version for higher performance 

        static async Task Main(string[] args)
        {

            Task<int> result = LongProcess(); // if i dont write await here thread will not wait for this methods execution to end
            ShortProcess();

            int value = await result;
            // Task async work with no return value
            Task<int> task1 = DoWorkAsync();
            Task<int> task2 = GetDataAsync();
            int[] allTasks = await Task.WhenAll(task1, task2); // when all the tasks are completed 
            Console.WriteLine(allTasks[0]);
            Console.WriteLine(allTasks[1]);
            // Arrow function or Lambda function 
            int sumofNum = await CalculateAsync();
            Console.WriteLine(sumofNum);
        }
        static async Task<int> LongProcess()
        {
            Console.WriteLine("LongProcess Started ...");
            await Task.Delay(4000);
            Console.WriteLine("LongProcess Ended ...");
            return 10;
        }

        static void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started...");

            Console.WriteLine("ShortProcess Ended ...");
        }
        public static async Task<int> DoWorkAsync()
        {
            Console.WriteLine("DoWorkAsync Started");

            await Task.Delay(3000);
            Console.WriteLine("DoWorkAsync Started");
            return 300;
           
        }
        public static async Task<int> GetDataAsync()
        {
            Console.WriteLine("GetDataAsync Started");
            await Task.Delay(5000);
            Console.WriteLine("GetDataAsync Finished");

            return 500;
        }
        static async Task<int> CalculateAsync()
        {
            return await Task.Run(() =>
            {
                int sum = 0;
                for(int i=0; i<100; i++)
                {
                    sum += i;
                }
                return sum;
            });
        }


    }
}
