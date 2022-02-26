using ConsoleAppArchitect.Data.IRepositories;
using ConsoleAppArchitect.Domains.Models;

namespace ConsoleAppArchitect.Data.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
    }
}
