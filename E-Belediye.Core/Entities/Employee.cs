using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeWorkingId { get; set; }
        public string EmployeeType { get; set; }
        public decimal Salary { get; set; }
        public DateTime WorkStartDate { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int WorkingUnitId { get; set; }
        public WorkingUnit WorkingUnit { get; set; }

    }
}
