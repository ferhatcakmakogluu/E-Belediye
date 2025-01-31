using E_Belediye.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.DTOs.ReminderDTOs
{
    public class RemindersOfEmployeeDto : ReminderDto
    {
        public Employee Employee { get; set; }
    }
}
