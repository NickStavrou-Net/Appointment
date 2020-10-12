using Appointement_Services.Interfaces;
using Appointment_UI.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Appointement_Services.Services
{
    public abstract class GenericService<TEntity,TContext> : IGenericService<TEntity> 
                                                                where TEntity : class
                                                                where TContext : AppDbContext
    {
        protected readonly AppDbContext _appContext;

        public GenericService(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            _appContext.Set<TEntity>().Add(entity);
            await _appContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _appContext.Set<TEntity>().FirstOrDefaultAsync(expression);
        }

        public async Task<IReadOnlyList<TEntity>> GetAllAsync()
        {
            return await _appContext.Set<TEntity>().ToListAsync();
        }

        //public async Task<TEntity> GetByIdAsync(int id)
        //{
        //    return await _appContext.Set<TEntity>().Find(id);
        //}

        public async Task<TEntity> Updatesync(TEntity entity)
        {
            _appContext.Update(entity);
            await _appContext.SaveChangesAsync();
            return entity;
        }
    }
}
