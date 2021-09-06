using Appointment.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointment_UI.AppContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base (options) { }

        public DbSet<Appointments> Appointments { get; set; }

    }
}
