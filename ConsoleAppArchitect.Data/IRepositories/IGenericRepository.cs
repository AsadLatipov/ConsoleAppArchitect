using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConsoleAppArchitect.Data.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Create(T entity);
        Task<T> UpdateASync(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<T> DeleteAsync(Expression<Func<T, bool>> expression);
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null);
    }
}
