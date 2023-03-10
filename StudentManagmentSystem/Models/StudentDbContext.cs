using Microsoft.EntityFrameworkCore;

namespace StudentManagmentSystem.Models
{
    public class StudentDbContext: DbContext
    {
        public StudentDbContext(DbContextOptions options): base(options) 
        {
           
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<EducationDetails> EducationDetail { get; set; }

        
    }
}
