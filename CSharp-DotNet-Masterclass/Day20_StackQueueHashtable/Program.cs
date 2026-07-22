using System.IO.Compression;

namespace Day20_StackQueueHashtable
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Stack
            // Last In First Out
            // It's Part of System.Generic.Collection
            // Push and Pop Operation
            Stack<int> stack = new Stack<int>();

            //Push method to add element to stack
            stack.Push(99);
            stack.Push(78);
            stack.Push(65);

            //pop method to remmove last added element which is on top of the stack
            int x = stack.Pop();
            Console.WriteLine(x);

            //Peek method - To get the element on top of the stack
            int y = stack.Peek();
            Console.WriteLine(y);

            //Application forward and backward 
            BrowserHistory browser = new BrowserHistory("google.com");
            Console.WriteLine(browser.GoBack()); // nothing in stack so by default google.com
            Console.WriteLine(browser.GoForward()); // same google.com

            browser.Visit("page1.com");
            browser.Visit("page2.com");
            browser.Visit("page3.com");
            browser.Visit("page4.com");

            Console.WriteLine(browser.GoBack()); // output : page 3
            Console.WriteLine(browser.GoBack()); // output : page 2
            Console.WriteLine(browser.GoBack()); // output : page 1
            Console.WriteLine(browser.GoBack()); // output : google.com
            Console.WriteLine(browser.GoForward()); // output : page 1
            Console.WriteLine(browser.GoForward()); // output : page 2
            Console.WriteLine(browser.GoForward()); // output : page 3
            Console.WriteLine(browser.GoForward()); // output : page 4



        }
    }
}
