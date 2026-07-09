using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Arrays_Static_PartialClass
{
    internal class BankAccount
    {
        // static field one copy is shared across ALL the objects 

        // count of how many accounts have been created
        public static int TotalAccount = 0;

        // Instance Field : Seprate Copy for each Object 
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountHolder, decimal balance) 
        {
            AccountHolder = accountHolder;
            Balance = balance;

            // Every time new account is created this shared counter will increase 
            TotalAccount++;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Account Holder : {AccountHolder}");
            Console.WriteLine($"Balance : {Balance}");
            Console.WriteLine($"Total Accounts : {TotalAccount}");
            Console.WriteLine();
        }
    }
}
