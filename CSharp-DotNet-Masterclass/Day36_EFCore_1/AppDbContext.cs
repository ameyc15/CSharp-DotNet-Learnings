using Day36_EFCore_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Day36_EFCore_1
{
    public class AppDbContext : DbContext
    {
        private string connectionString = "Data Source=AMEY;Initial Catalog=LocalDb;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;";
        
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
