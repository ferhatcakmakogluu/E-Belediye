using E_Belediye.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.Repositories
{
    public interface ITrafficDataRepository : IGenericRepository<TrafficData>
    {
        Task<TrafficData> GetTraficDataByEmployeeId(int employeeId);
        Task<List<TrafficData>> GetAllTraficDataWithEmployee();
    }
}
