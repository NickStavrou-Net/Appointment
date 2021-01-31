﻿using Appointment_UI.Models;
using System.Collections.Generic;

namespace Appointment.Models
{
    public class Appointments
    {
        public int Id { get; set; }
        //public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        //public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public Dates AppointmentDate { get; set; }
        public ICollection<Service> Services { get; set; }
        public int AppointmentDuration { get; set; }
        public decimal TotalPrice { get; set; }
        public bool NotifyCustomer { get; set; }
        public bool IsApproved { get; set; } = false;

    }
}
