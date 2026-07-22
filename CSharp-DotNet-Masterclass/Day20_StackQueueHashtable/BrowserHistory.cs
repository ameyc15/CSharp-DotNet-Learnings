using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day20_StackQueueHashtable
{
    public class BrowserHistory
    {
        private Stack<string> backwordStack = new Stack<string>();
        
        private Stack<string> forwardStack = new Stack<string>();

        private string currentURL;

        public BrowserHistory(string homePage)
        {
            currentURL = homePage;
        }
        public void Visit(string url)
        {
            backwordStack.Push(currentURL);
            currentURL = url;
        }
        public string GoBack()
        {
            if (backwordStack.Count > 0) 
            {
                forwardStack.Push(currentURL);
                currentURL = backwordStack.Pop();
            }
            return currentURL;
        }
        public string GoForward()
        {
            if(forwardStack.Count > 0)
            {
                backwordStack.Push(currentURL);
                currentURL = forwardStack.Pop();
            }
            return currentURL;
        }
    }
}
