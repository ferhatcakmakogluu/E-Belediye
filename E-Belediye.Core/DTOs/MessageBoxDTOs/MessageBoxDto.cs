using E_Belediye.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.DTOs.MessageBoxDTOs
{
    public class MessageBoxDto
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int RecieverId { get; set; } //me
        public bool IsSeen { get; set; } = false;
        public DateTime? SeenDate { get; set; }
        public int EmployeeId { get; set; } //sender
    }
}
