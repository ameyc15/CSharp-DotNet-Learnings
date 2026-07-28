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
    }
}
