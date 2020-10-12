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
    public class CustomerService1 : ICustomerService
    {
        private readonly AppDbContext _appDbContext;

        public CustomerService1(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
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
