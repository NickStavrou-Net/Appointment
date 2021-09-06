using System;

namespace Appointment.Models
{
    public class Appointments
    {
        public int Id { get; set; }
        public DateTime TaskEndDate  { get; set; }
        public DateTime TaskDate { get; set; }
        public string Description { get; set; }        
        public string Title { get; set; }
        public bool IsCompleted { get; set; } = false;
        public int NotificationInMinutes { get; set; }

    }
}
