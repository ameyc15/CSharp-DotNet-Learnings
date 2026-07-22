using System.Collections;
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


            // Queue : First In First Out 
            Queue<int> orderId = new Queue<int>();
            orderId.Enqueue(12);
            orderId.Enqueue(13);
            orderId.Enqueue(14);
            orderId.Enqueue(15);

            Console.WriteLine(orderId.Dequeue()); //12
            Console.WriteLine(orderId.Dequeue()); //13

            // Hash table  stores in key value pair 
           Hashtable monthNames =  new Hashtable();

            monthNames.Add(1, "Jan");
            monthNames.Add(2, "Feb");
            monthNames.Add(3, "Mar");
            monthNames.Add(4, "Apr");
            monthNames.Add(5, "May");
            monthNames.Add(6, "Jun");
            monthNames.Add(7, "Jul");
            monthNames.Add(8, "Aug");

            monthNames.Remove(8);

            foreach(DictionaryEntry pair in monthNames)
            {
                Console.WriteLine("Value  : " + pair.Value + "   Key  : " + pair.Key) ;
            }

            // using hashtbales segregate into two sets odd and even 
            int[] arr = { 12, 15, 20, 34, 14, 94 };

            Hashtable ht = new Hashtable();

            for (int i = 0; i < arr.Length; i++) 
            {
                string key = (arr[i] % 2 == 0) ? "even" : "odd";

                if (!ht.ContainsKey(key))
                {
                    ht[key] = new ArrayList();
                }

                ((ArrayList)ht[key]).Add(arr[i]);
            }

            foreach(var item in (ArrayList)ht["even"])
            {
                Console.WriteLine(item);
            }


        }
    }
}
