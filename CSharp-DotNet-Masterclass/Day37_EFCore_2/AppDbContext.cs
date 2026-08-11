using Day37_EFCore_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day37_EFCore_2
{
    internal class AppDbContext : DbContext
    {
        private string connectionString = "Data Source=AMEY;Initial Catalog=LocalDb;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;";

        // db sets
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }
        // override
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
