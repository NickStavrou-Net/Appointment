using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorAppointment.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime TaskEndDate { get; set; }
        public DateTime TaskDate { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; } = false;
        public int NotificationInMinutes { get; set; }
    }
}
