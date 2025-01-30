using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.Entities
{
    public class TaskProcess
    {
        public int Id { get; set; }
        public string TaskNumberId { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public string TaskType { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime? TaskEndDate { get; set; }
        public int UnitLeadId { get; set; }
        public UnitLead UnitLead { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
