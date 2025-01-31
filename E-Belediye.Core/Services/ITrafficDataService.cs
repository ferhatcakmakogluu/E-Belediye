using E_Belediye.Core.DTOs;
using E_Belediye.Core.DTOs.TrafficDataDTOs;
using E_Belediye.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.Services
{
    public interface ITrafficDataService
    {
        Task<CustomResponseDto<TrafficDataOfEmployeeDto>> GetTraficDataByEmployeeId(int employeeId);
        Task<CustomResponseDto<List<TrafficDataOfEmployeeDto>>> GetAllTraficDataWithEmployee();
    }
}
