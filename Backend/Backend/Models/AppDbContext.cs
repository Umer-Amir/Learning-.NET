using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // This creates the 'Employees' table in SQL Server
        public DbSet<Employee> Employees { get; set; }
    }
}