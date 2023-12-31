using Hospital.Utilities;
using Hospital.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Services
{
    public interface IContactService
    {
        PagedResult<ApplicationUserViewModel> GetAll(int pageNumber, int pageSize);

        ApplicationUserViewModel GetContactById(int Contactid);
      
        void InsertContact(ApplicationUserViewModel vm);
        void UpdateContact(ApplicationUserViewModel vm);
        void DeleteContact(int id);
    }
}
