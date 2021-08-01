using Appointment.Models;
using Appointment_UI.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointment_UI.AppContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base (options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Dates> Dates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dates>()
                .HasKey(d => d.DateId);

            modelBuilder.Entity<Appointments>()
                .HasOne(d => d.AppointmentDate)
                .WithOne(a => a.Appointment)
                .HasForeignKey<Dates>(d => d.DateId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
