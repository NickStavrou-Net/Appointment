using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Appointment_UI.Interfaces
{
    public interface IService<T> where T : class
    {
        ValueTask<T> CreateCustomerAsync(T entity);
        ValueTask<T> RetrieveCustomerByIdAsync(Expression<Func<T, bool>> expression);
        ValueTask<T> UpdateCustomerAsync(T entity);
        ValueTask<IReadOnlyList<T>> GetAllCustomersAsync();
    }
}
