using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.DTOs.ReminderDTOs
{
    public class ReminderDto
    {
        public int Id { get; set; }
        public string ReminderTitle { get; set; }
        public string ReminderType { get; set; }
        public DateTime EndDate { get; set; }
        public int EmployeeId { get; set; }
    }
}
