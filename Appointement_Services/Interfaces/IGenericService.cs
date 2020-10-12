using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Appointement_Services.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        ///// <summary>
        ///// Get the entity by id.
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //Task<T> GetByIdAsync(int id);

        /// <summary>
        /// Get all entities in a readonly list.
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<T>> GetAllAsync();
        /// <summary>
        /// Finds a set of record that matches the passed expression.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<T> FindAsync(Expression<Func<T, bool>> expression);

        /// <summary>
        /// Adds a new record to the context.
        /// </summary>
        /// <param name="entity"></param>
        Task<T> AddAsync(T entity);

        /// <summary>
        /// Adds a new record to the context.
        /// </summary>
        /// <param name="entity"></param>
        Task<T> Updatesync(T entity);

        /// <summary>
        /// Add a list of records to the context.
        /// </summary>
        /// <param name="entities"></param>
        //void AddRange(IEnumerable<T> entities);
        ///// <summary>
        ///// Removes a record from the context.
        ///// </summary>
        ///// <param name="entity"></param>
        //void Remove(T entity);
        ///// <summary>
        ///// Removes a list of records.
        ///// </summary>
        ///// <param name="entities"></param>
        //void RemoveRange(IEnumerable<T> entities);
    }
}
