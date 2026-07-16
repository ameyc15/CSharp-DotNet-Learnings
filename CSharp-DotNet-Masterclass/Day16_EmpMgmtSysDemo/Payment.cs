using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_EmpMgmtSysDemo
{
    public class Payment : Generic
    {
        public string Id { get; set; }
        public string Amount { get; set; }

        public DateTime PaymentDate = DateTime.Now;

        public Payment()
        {
            Console.WriteLine("Payment Class Defualt Constructor Invoked");
        }

        public Payment(int amount)
        {
            Console.WriteLine("Payment Class Parameterised Const Amount" + amount);
        }
        

        // Compile Time Polymorphism
        public void ProcessPayment(int amount)
        {
            Console.WriteLine("Payment done Amount is : " + amount);
        }
        public void ProcessPayment(int amount, string bankName)
        {
            Console.WriteLine("Payment done Amount is "+amount+"Bank is" + bankName);
        }
            

    }
}
