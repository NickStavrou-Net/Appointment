using Appointment.Models;
using System;

namespace Appointment_UI.Models
{
    public class Dates
    {
        public int DateId { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeFinish { get; set; }
        public DateTime DateofAppointment { get; set; }
        public Appointments Appointment { get; set; }
    }
}
