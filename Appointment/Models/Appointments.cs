using Appointment_UI.Models;
using System.Collections.Generic;

namespace Appointment.Models
{
    public class Appointments
    {
        public int Id { get; set; }
        //public int UserId { get; set; }
        public User User { get; set; }
        public Dates AppointmentDate { get; set; }
        public string Description { get; set; }        
        public string Title { get; set; }
        public bool IsCompleted { get; set; } = false;

    }
}
