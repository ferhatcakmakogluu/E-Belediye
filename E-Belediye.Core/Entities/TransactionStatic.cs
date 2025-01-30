using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.Entities
{
    public class TransactionStatic
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public List<TrafficData> TrafficDatas { get; set; }
    }
}
