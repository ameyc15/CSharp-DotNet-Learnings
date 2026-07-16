using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_EmpMgmtSysDemo
{
    public  class CreditCard : Payment
    {
        public string CardId { get; set; }
        public string CardName { get; set; } = string.Empty;

        public string CardType { get; set; }
        public CreditCard()
        {
            Console.WriteLine("Credit Card Defualt Constructor Invoked");
        }
        public CreditCard(int amount) : base(amount) 
        {
            Console.WriteLine("Credit Card Parameterised Const Amount : " + amount);
        }
    }
}
