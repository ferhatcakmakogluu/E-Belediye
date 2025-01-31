using E_Belediye.Core.DTOs;
using E_Belediye.Core.DTOs.EmployeeDTOs;
using E_Belediye.Core.Entities;
using E_Belediye.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.Services
{
    public interface IEmployeeService<T> : IGenericRepository<T> where T : class
    {
        Task<CustomResponseDto<EmployeeWithPersonDto>> GetEmployeeWithPersonInformationById(int employeeId);
        Task<CustomResponseDto<List<EmployeeWithPersonDto>>> GetAllEmployeeWithPersonInformation();
        Task<CustomResponseDto<EmployeeWithWorkingUnitDto>> GetEmployeeWithWorkingUnitById(int employeeId);
        Task<CustomResponseDto<List<EmployeeWithWorkingUnitDto>>> GetAllEmployeeWithWorkingUnit();
        Task<CustomResponseDto<EmployeeWithPersonAndWorkingUnitDto>> GetEmployeeWithAllInformationById(int employeeId);
        Task<CustomResponseDto<List<EmployeeWithPersonAndWorkingUnitDto>>> GetAllEmployeeWithAllInformation();
    }
}
