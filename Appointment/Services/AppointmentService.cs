using Appointement_Services.Interfaces;
using Appointment.Models;
using Appointment_UI.AppContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Appointement_Services.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly AppDbContext _appDbContext;

        public AppointmentService(AppDbContext appDbContext) => _appDbContext = appDbContext;

        public async Task<int> ConfirmAppointment(int id)
        {
            var appointment = _appDbContext.Appointments.FirstOrDefault(a => a.Id == id);
            if (appointment is not null)
            {
                appointment.IsApproved = true;
            }
            return await _appDbContext.SaveChangesAsync();
        }

        public async ValueTask<Customer> CreateCustomerAsync(Customer customer)
        {
            _appDbContext.Add(customer);
            await _appDbContext.SaveChangesAsync();
            return customer;

        }

        public async ValueTask<IReadOnlyList<Customer>> GetAllCustomersAsync()
        {
            return await _appDbContext.Customers.ToListAsync();
        }

        public async ValueTask<Customer> RetrieveCustomerByIdAsync(Expression<Func<Customer, bool>> expression)
        {
            return await _appDbContext.Customers.FirstOrDefaultAsync(expression);
        }

        public async ValueTask<Customer> UpdateCustomerAsync(Customer customer)
        {
            _appDbContext.Customers.Update(customer);
            await _appDbContext.SaveChangesAsync();
            return customer;
        }
    }
}
