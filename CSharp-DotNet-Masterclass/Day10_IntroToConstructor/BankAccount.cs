using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        static double balance { get; set; }
        public string bankName { get; set; }

        // Constructor :  Special Method with no return type but same name as class name
        // Uses : 1. Used to initialise the fields 
        public BankAccount()
        {
            Console.WriteLine("Constructor without parameter invoked");
            balance = 1000;
        }
        // Parammeterised Constructor will be invoked using BankAccount acc1 = new BankAccount(300);
        public BankAccount(double amount)
        {
            Console.WriteLine("Constructor with one parameter invoked");
            balance = amount;
            Console.WriteLine("Balance is : " + balance);
        }
        public BankAccount(string bankname, double amount)
        {
            Console.WriteLine("Constructor with two Parameter invoked");
            bankName = bankname;
            balance = amount;
            Console.WriteLine("Balance is : "+ balance + "\nBankName is : "+bankName);
        }
    }
}
