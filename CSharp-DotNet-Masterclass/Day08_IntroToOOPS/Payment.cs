using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_IntroToOOPS
{
    public class Payment
    {
        public  int amount;
        public bool isPaymentDone;
        public static int  amount1 = 200; // static property is for class level not object level

        public void Pay()
        {
            isPaymentDone = true;
            amount = 100;
            Console.WriteLine("Method  Pay is invoked and Payment is successfull");
            Console.WriteLine($"Static property amount1 calling from Pay method Paymennt class {amount1}");          


        }
    }
}
