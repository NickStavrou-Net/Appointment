using Appointment.Models;
using Appointment_UI.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appointment_UI.Services
{
    public class CustomerService : BaseService<Customer, AppDbContext>
    {
        public CustomerService(AppDbContext context) : base(context)
        {

        }

    }
}
