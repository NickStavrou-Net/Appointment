using Appointment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Appointement_Services.Interfaces
{
    public interface ICustomerService
    {
        ValueTask<Customer> CreateCustomerAsync(Customer customer);
        ValueTask<Customer> RetrieveCustomerByIdAsync(Expression<Func<Customer, bool>> expression);
        ValueTask<Customer> UpdateCustomerAsync(Customer customer);
        ValueTask<IReadOnlyList<Customer>> GetAllCustomersAsync();
    }
}
