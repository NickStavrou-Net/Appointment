using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appointment.Models
{
    public class Appointments
    {
        public int AppointmentsId { get; set; }
        //public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        //public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public ICollection<Service> Services { get; set; }
        public int AppointmentsDurationInMinits { get; set; }
        public decimal TotalPrice { get; set; }
        public bool NotifyCustomer { get; set; }
        public DateTime AppointmentsDate { get; set; }
    }
}
