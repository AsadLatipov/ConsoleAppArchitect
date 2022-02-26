using ConsoleAppArchitect.Domains.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppArchitect.Data.Contexts
{
    public class MYDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("host=localhost; user id=postgres; port=5432; password=asadbek; database=My DB;");
        }
    }
}

