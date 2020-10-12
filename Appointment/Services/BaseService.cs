using Appointment_UI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Appointment_UI.Services
{
    public abstract class BaseService<T, TContext> : IService<T>
        where T : class
        where TContext : DbContext
    {
        private readonly TContext _context;
        public BaseService(TContext context)
        {
            _context = context;
        }

        public async ValueTask<T> CreateCustomerAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async ValueTask<IReadOnlyList<T>> GetAllCustomersAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async ValueTask<T> RetrieveCustomerByIdAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().FindAsync(expression);
        }

        public async ValueTask<T> UpdateCustomerAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
