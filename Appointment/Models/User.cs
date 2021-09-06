using System.Collections.Generic;

namespace Appointment.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{LastName} {FirstName}"; } }
        public ICollection<Appointments> Appointments { get; set; }
    }
}
