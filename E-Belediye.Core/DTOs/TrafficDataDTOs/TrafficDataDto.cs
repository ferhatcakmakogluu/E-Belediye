using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.DTOs.TrafficDataDTOs
{
    public class TrafficDataDto
    {
        public int Id { get; set; }
        public string TrafficName { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeId { get; set; }
    }
}
