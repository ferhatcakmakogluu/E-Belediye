using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.Entities
{
    public class MessageBox
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int RecieverId { get; set; } //me
        public bool IsSeen { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime? SeenDate { get; set; }
        public int EmployeeId { get; set; } //sender
        public Employee Employee { get; set; }
    }
}
