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

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<users>();
            modelBuilder.Entity<Intern>();
            modelBuilder.Entity<programs>();
            modelBuilder.Entity<mentor>();
            modelBuilder.Entity<Intern_Programs>();
            modelBuilder.Entity<report>();
            modelBuilder.Entity<feedback>();

            modelBuilder.Entity<Intern>()
                .HasOne(i => i.users)
                .WithMany()
                .HasForeignKey(i => i.UserId);

            modelBuilder.Entity<Intern_Programs>()
                .HasOne(ip => ip.Intern)
                .WithMany()
                .HasForeignKey(ip => ip.InternId);

            modelBuilder.Entity<Intern_Programs>()
                .HasOne(ip => ip.programs)
                .WithMany()
                .HasForeignKey(ip => ip.ProgramId);

            modelBuilder.Entity<Intern_Programs>()
                .HasOne(ip => ip.mentor)
                .WithMany()
                .HasForeignKey(ip => ip.MentorId);

            modelBuilder.Entity<report>()
                .HasOne(r => r.Intern_Programs)
                .WithMany()
                .HasForeignKey(r => r.InternProgramId);

            modelBuilder.Entity<feedback>()
                .HasOne(f => f.report)
                .WithMany()
                .HasForeignKey(f => f.ReportId);
        }
   */
    }
}
