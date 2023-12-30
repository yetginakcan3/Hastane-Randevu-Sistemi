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
        PagedResult<ContactViewModel>GetAll(int pageNumber,  int pageSize);
        ContactViewModel GetContactById(int ContactId);
        void UpdateContact (ContactViewModel contact);
        void InsertContact (ContactViewModel contact);
        void DeleteContact (int id);
        string? GetRoomById(int id);
        void UpdateRoom(RoomViewModel vm);
        void InsertRoom(RoomViewModel vm);
        void DeleteRoom(int id);
    }
}
