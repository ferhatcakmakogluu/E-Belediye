using E_Belediye.Core.DTOs;
using E_Belediye.Core.DTOs.MessageBoxDTOs;
using E_Belediye.Core.Entities;
using E_Belediye.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.Services
{
    public interface IMessageBoxService : IGenericRepository<MessageBox>
    {
        //Task<CustomResponseDto<List<EmployeeForRecieveMessageDto>>> GetAllMessageOfSenderById(int senderId);
        Task<CustomResponseDto<List<EmployeeForRecieveMessageDto>>> GetAllMessageOfSenderToReciever(int senderId, int recieverId);
    }
}
