using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day37_EFCore_2.Models
{
    internal class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        // one to many relationship --one department can have many employees
        public List<Employee> Employees { get; set; }

    }
}
