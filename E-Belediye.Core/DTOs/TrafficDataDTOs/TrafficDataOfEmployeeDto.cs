using E_Belediye.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.DTOs.TrafficDataDTOs
{
    public class TrafficDataOfEmployeeDto : TrafficDataDto
    {
        public Employee Employee { get; set; }
    }
}
