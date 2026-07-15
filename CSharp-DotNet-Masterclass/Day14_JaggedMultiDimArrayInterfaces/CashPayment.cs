using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_JaggedMultiDimArrayInterfaces
{
    public class CashPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Cash Payment Done !!!");
        }
    }
}
