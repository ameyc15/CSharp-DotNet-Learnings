using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_JaggedMultiDimArrayInterfaces
{
    internal class CreditCardPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Credit Card Payment Done !!!");
        }
    }
}
