using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_ClassObjectFieldMethod
{
    internal class BankAccount
    {
        // Question 2 :  Create an BankAcount class with field Balance 
        // write a method  Deposit and GetBalance        
        public double Balance = 100;

        public double Deposit(double amount)
        {
            return Balance = Balance + amount;
        }

        public void GetBalance()
        {
            Console.WriteLine(Balance);
        }
    }
}
