using E_Belediye.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.DTOs.EmployeeDTOs
{
    public class EmployeeWithWorkingUnitDto : EmployeeDto
    {
        public WorkingUnit WorkingUnit { get; set; }
    }
}
