using Microsoft.EntityFrameworkCore;

namespace Codenation.Challenge.Models
{
    public class CodenationContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Acceleration> Accelerations  { get; set; }
        public DbSet<Challenge> Challenges  { get; set; }
        public DbSet<Candidate> Candidates  { get; set; }
        public DbSet<Submission> Submissions  { get; set; }
                
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Codenation;Trusted_Connection=True");            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>()
                .HasKey(x => new { x.User_Id, x.Acceleration_Id, x.Company_Id, x.Status, x.Created_at });
            modelBuilder.Entity<Submission>()
                .HasKey(x => new { x.User_Id, x.Chanllege_Id, x.Score });
        }
    }
}