using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ServerSide.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<CprRecord> Cprs { get; set; }
        public DbSet<Todolist> Todolists { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Cpr-User relationship
            modelBuilder.Entity<CprRecord>()
                .HasOne(c => c.User)
                .WithMany() // One user can have multiple Cpr records
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);  // Delete CPR when user is deleted

            // Configure Todolist-Cpr relationship
            modelBuilder.Entity<Todolist>()
               .HasOne(t => t.User)
               .WithMany()
               .HasForeignKey(t => t.UserId)
               .OnDelete(DeleteBehavior.Cascade); // Delete Todolist when Cpr is deleted
        }

    }


}
