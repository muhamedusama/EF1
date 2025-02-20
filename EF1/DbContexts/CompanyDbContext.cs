using EF1.Models;
using Microsoft.EntityFrameworkCore;
namespace EF1.DbContexts
{
    internal class CompanyDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public CompanyDbContext():base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=CompanyDb; Integ;rated Security = true");
            optionsBuilder.UseSqlServer("Server = .; Database = CompanyDb; Trusted_Connection = true; TrustServerCertificate=True");
        }

    }
}
