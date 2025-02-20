using EF1.Models;
using Microsoft.EntityFrameworkCore;


namespace EF1.DbContexts
{
    internal class ItIDbContext : DbContext
    {

        
        
        public DbSet<Student> Students{ get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Stud_Course> Students_Courses{ get; set; }
        public DbSet<Topic> Topics{ get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<Course_Inst> Courses_Instructors{ get; set; }
        public DbSet<Instructor> Instructors{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = CompanyDb; Trusted_Connection = true; TrustServerCertificate=True");
        }
    }
}
