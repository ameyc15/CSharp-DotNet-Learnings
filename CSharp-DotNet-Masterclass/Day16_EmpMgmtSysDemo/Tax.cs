using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_EmpMgmtSysDemo
{
    internal class Tax
    {
        int HighRate = 10;
        int LowRate = 5;
        public int CalculateTax(int ctc)
        {
            int tax = 0;
            if(ctc < 0)
            {
                return tax;
            }
            if(ctc > 1000000)
            {
                return ctc * HighRate / 100;
            }
            else
            {
                return (ctc * LowRate / 100);
            }
                return tax;
        }
    }
}
