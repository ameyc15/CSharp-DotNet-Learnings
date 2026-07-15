using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_OOPSPartOne
{
    public class Person
    {
        public string FirstName;

        public string LastName;

        public string GetName()
        {
            return FirstName+ " "+LastName;
        }
    }
}
