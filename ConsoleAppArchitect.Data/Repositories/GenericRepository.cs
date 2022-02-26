using ConsoleAppArchitect.Data.Contexts;
using ConsoleAppArchitect.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConsoleAppArchitect.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DbContext _db;
        private DbSet<T> dbset { get; set; }
        public GenericRepository()
        {
            _db = new MYDBContext();
            this.dbset = _db.Set<T>();
        }

#pragma warning disable
        /// <summary>
        /// Returns many rows that satisfy the expression, otherwise returns the table
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null)
        {
            Expression<Func<T, bool>> pred = x => true;
            return dbset.Where(expression ?? pred);
        }


        /// <summary>
        /// Delete the first row that satisfies the expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<T> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await dbset.FirstOrDefaultAsync(expression);
            dbset.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }


        /// <summary>
        /// Get the first row that satisfies the expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await dbset.FirstOrDefaultAsync(expression);
        }


        /// <summary>
        /// Updates the given entity according to the primary key
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> UpdateASync(T entity)
        {
            var enty = dbset.Update(entity);
            await _db.SaveChangesAsync();
            return enty.Entity;
        }

        /// <summary>
        /// Adds the entity you provided to the database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> Create(T entity)
        {
            var enty = await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return enty.Entity;
        }
    }
}
