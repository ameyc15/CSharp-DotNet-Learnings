using Day38_EF_SampleApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace Day38_EF_SampleApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Employee> Employees { get; set; }
    }
}
