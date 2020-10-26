using Appointment.Models;
using Appointment_UI.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appointment_UI.Services
{
    public class EmployeeService : BaseService<Employee, AppDbContext>
    {
        public EmployeeService(AppDbContext context) : base(context)
        {

        }

    }
}
