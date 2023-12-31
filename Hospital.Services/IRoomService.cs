using Hospital.Utilities;
using Hospital.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Services
{
    public interface IRoomService
    {
        PagedResult<RoomViewModel>GetAll(int pageNumber,  int pageSize);
        RoomViewModel GetRoomById(int RoomId);
        
        
       
        void UpdateRoom(RoomViewModel vm);
        void InsertRoom(RoomViewModel vm);
        void DeleteRoom(int id);
    }
}
