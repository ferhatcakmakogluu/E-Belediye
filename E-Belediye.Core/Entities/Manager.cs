using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.Entities
{
    public class Manager : Employee
    {
        public WorkingUnit WorkingUnit { get; set; }
    }
}
