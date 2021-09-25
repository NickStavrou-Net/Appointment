using Microsoft.EntityFrameworkCore;
using RazorAppointment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorAppointment.AppContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Appointment> Appointments { get; set; }

    }
}
