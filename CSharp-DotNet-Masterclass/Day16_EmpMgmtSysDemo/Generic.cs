using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_EmpMgmtSysDemo
{
    public class Generic
    {
        public Guid Id { get; set; }

        public DateTime CreatedOn = DateTime.Now;

        public DateTime UpdatedOn = DateTime.Now;
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
