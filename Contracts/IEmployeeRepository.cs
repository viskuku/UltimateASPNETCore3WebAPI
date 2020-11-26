using System.Threading.Tasks;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IEmployeeRepository
    {
       Task<IEnumerable<Employee>> GetEmployeesAsync(Guid companyId, bool trackChanges);
       Task<Employee> GetEmployeeAsync(Guid companyId, Guid id, bool trackChanges);
        void CreateEmployeeForCompany(Guid companyId, Employee employee);
        void DeleteEmployee(Employee employee);

    }
}
