using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.Entities
{
    public class Officer : Employee
    {
        public int WorkingUnitId { get; set; }
        public WorkingUnit WorkingUnit { get; set; }
    }
}
