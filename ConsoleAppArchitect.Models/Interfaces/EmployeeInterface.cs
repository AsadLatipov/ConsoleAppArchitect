using ConsoleAppArchitect.Domains.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConsoleAppArchitect.Service.Interfaces
{
    internal interface EmployeeInterface
    {
        Task<Employee> Create(Employee entity);
        Task UpdateASync(Employee entity);
        Task GetAsync(Expression<Func<Employee, bool>> expression);
        Task DeleteAsync(Expression<Func<Employee, bool>> expression);
        Task<IQueryable<Employee>> GetAllAsync(Expression<Func<Employee, bool>> expression = null);
    }
}
