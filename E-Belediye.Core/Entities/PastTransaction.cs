using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.Entities
{
    public class PastTransaction
    {
        public int Id { get; set; }
        public string TransactionId { get; set; }
        public List<TrafficData> TrafficDatas { get; set; }
    }
}
