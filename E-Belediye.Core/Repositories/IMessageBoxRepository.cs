using E_Belediye.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Core.Repositories
{
    public interface IMessageBoxRepository : IGenericRepository<MessageBox>
    {
        Task<List<MessageBox>> GetAllMessageOfSenderById(int senderId);
        Task<List<MessageBox>> GetAllMessageOfSenderToReciever(int senderId, int recieverId);
    }
}
