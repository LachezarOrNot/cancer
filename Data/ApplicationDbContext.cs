using EffiSenseRe.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EffiSenseRe.Data {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
        public DbSet<Home> Homes { get; set; }
        public DbSet<Device> Devices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Home>()
                .HasOne(h => h.User)
                .WithMany(u => u.Homes) 
                .HasForeignKey(h => h.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Device>()
                .HasOne(d => d.Home)
                .WithMany(h => h.Devices)
                .HasForeignKey(d => d.HomeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
