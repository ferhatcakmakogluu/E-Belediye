using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.Repositories
{
    public interface IEmployeeRepository<T> : IGenericRepository<T> where T : class
    {
        Task<T> GetEmployeeWithPersonInformationById(int employeeId);
        Task<List<T>> GetAllEmployeeWithPersonInformation();
        Task<T> GetEmployeeWithWorkingUnitById(int employeeId);
        Task<List<T>> GetAllEmployeeWithWorkingUnit();
        Task<T> GetEmployeeWithAllInformationById(int employeeId);
        Task<List<T>> GetAllEmployeeWithAllInformation();
    }
}
