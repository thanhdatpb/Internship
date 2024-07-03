namespace Internship.Models
{
    public class InternshipDbContext : DbContext
    {
        public InternshipDbContext(DbContextOptions<InternshipDbContext> options)
            : base(options)
        {
        }

        public DbSet<users> Users { get; set; }
        public DbSet<Intern> Interns { get; set; }
        public DbSet<programs> Programs { get; set; }
        public DbSet<mentor> Mentors { get; set; }
        public DbSet<Intern_Programs> InternPrograms { get; set; }
        public DbSet<report> Reports { get; set; }
        public DbSet<feedback> feedback { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<users>().ToTable("users");
            modelBuilder.Entity<Intern>().ToTable("Intern");
            modelBuilder.Entity<programs>().ToTable("programs");
            modelBuilder.Entity<mentor>().ToTable("mentor");
            modelBuilder.Entity<Intern_Programs>().ToTable("Intern_Programs");
            modelBuilder.Entity<report>().ToTable("report");
            modelBuilder.Entity<feedback>().ToTable("feedback");
        }
    }
}
