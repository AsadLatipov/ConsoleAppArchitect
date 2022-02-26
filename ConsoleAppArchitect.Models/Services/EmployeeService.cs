using ConsoleAppArchitect.Data.IRepositories;
using ConsoleAppArchitect.Data.Repositories;
using ConsoleAppArchitect.Domains.Models;
using ConsoleAppArchitect.Service.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConsoleAppArchitect.Service.Services
{
    internal class EmployeeService : EmployeeInterface
    {
        IEmployeeRepository generic = new EmployeeRepository();
        public Task<Employee> Create(Employee entity)
        {
            return generic.Create(entity);
        }

        public Task DeleteAsync(Expression<Func<Employee, bool>> expression)
        {
            return generic.DeleteAsync(expression);
        }

        public Task<IQueryable<Employee>> GetAllAsync(Expression<Func<Employee, bool>> expression = null)
        {
            return generic.GetAllAsync(expression);
        }

        public Task GetAsync(Expression<Func<Employee, bool>> expression)
        {
            return generic.GetAsync(expression);
        }

        public Task UpdateASync(Employee entity)
        {
            return generic.UpdateASync(entity);
        }
    }
}
