using E_Belediye.Core.DTOs;
using E_Belediye.Core.DTOs.ReminderDTOs;
using E_Belediye.Core.Entities;
using E_Belediye.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.Services
{
    public interface IReminderService : IGenericRepository<Reminder>
    {
        Task<CustomResponseDto<List<RemindersOfEmployeeDto>>> GetAllReminderOfEmployeeByEmployeeId(int employeeId);
    }
}
