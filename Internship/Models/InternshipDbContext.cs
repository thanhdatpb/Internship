using Microsoft.EntityFrameworkCore;

namespace Internship.Models
{
    public class InternshipDbContext : DbContext
    {
        public InternshipDbContext(DbContextOptions<InternshipDbContext> options)
            : base(options)
        {
        }

        public DbSet<users> users { get; set; }
        public DbSet<Intern> Interns { get; set; }
        public DbSet<programs> programs { get; set; }
        public DbSet<mentor> mentor { get; set; }
        public DbSet<Intern_Programs> InternPrograms { get; set; }
        public DbSet<report> Reports { get; set; }
        public DbSet<feedback> Feedback { get; set; }

    }
}
